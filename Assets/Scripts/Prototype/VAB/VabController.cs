using System.IO;
using Kosmos.Prototype.Parts;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Kosmos.Prototype.Vab
{
    public class VabController : MonoBehaviour
    {
        [Header("UI")]
        [SerializeField] private PartPickerPanel _partPickerPanel;
        [SerializeField] private PartInfoPanel _partInfoPanel;
        [SerializeField] private Camera _mainCam;
        
        [Header("Gizmos")]
        [SerializeField] private GizmoBase _moveGizmo;
        
        [Header("Input")]
        [SerializeField] private InputActionReference _mousePosition;
        [SerializeField] private InputActionReference _mouseDelta;
        
        [Header("Camera Control")]
        [SerializeField] private float _cameraMoveSpeed = 10.0f;
        [SerializeField] private float _cameraRotateSpeed = 10.0f;
        
        private PartCollection _vehicleRoot;
        private PartBase _selectedPart;

        private enum EControlState
        {
            None,
            DraggingGizmo,
            MovingCamera,
        }

        private EControlState _controlState = EControlState.None;
        private GizmoBase _currentGizmo; 

        void Start()
        {
            _partPickerPanel.OnPartPicked += OnPartPickerClicked;
            _partPickerPanel.OnLaunchButtonClicked += async () => await OnLaunchButtonClicked();

            _currentGizmo = _moveGizmo;

            _vehicleRoot = new GameObject("VehicleRoot").AddComponent<PartCollection>();
            SelectPart(null);

        }

        private async Awaitable OnLaunchButtonClicked()
        {
            string flightControlScenceName = "Prototype_FlightControl";
            Scene currentScene = SceneManager.GetActiveScene();
            await SceneManager.LoadSceneAsync(flightControlScenceName, LoadSceneMode.Additive);

            SceneManager.MoveGameObjectToScene(_vehicleRoot.gameObject, SceneManager.GetSceneByName(flightControlScenceName));

            await SceneManager.UnloadSceneAsync(currentScene);
        }

        private void OnPartPickerClicked(PartDefinition part)
        {
            var newPart = _vehicleRoot.AddPart(part);
            SelectPart(newPart);
        }

        public void OnScreenClick(InputAction.CallbackContext context)
        {
            //Part selection
            if (context.phase == InputActionPhase.Performed && _controlState == EControlState.None)
            {
                var part = GetPartUnderCursor();
                
                if (part != null)
                {
                        SelectPart(part);
                }
                else
                {
                    SelectPart(null);
                }
            }
        }

        public PartBase GetPartUnderCursor()
        {
            Vector2 mousePos = _mousePosition.action.ReadValue<Vector2>();
            var ray = _mainCam.ScreenPointToRay(mousePos);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                var part = hit.collider.GetComponentInParent<PartBase>();
                if (part != null)
                {
                    return part;
                }
            }

            return null;
        }

        public void OnScreenDrag(InputAction.CallbackContext context)
        {
            //Gizmo handling
            var mousePos = _mousePosition.action.ReadValue<Vector2>();
            if (context.phase == InputActionPhase.Started && _controlState == EControlState.None)
            {
                if (_currentGizmo.TestClick(mousePos, _mainCam))
                {
                    _controlState = EControlState.DraggingGizmo;
                    _currentGizmo.StartDrag(mousePos, _mainCam);
                }
            }
            else if (context.phase == InputActionPhase.Canceled && _controlState == EControlState.DraggingGizmo)
            {
                _currentGizmo.EndDrag(mousePos, _mainCam);
                _controlState = EControlState.None;
            }
        }
        
        public void OnMoveCamera(InputAction.CallbackContext context)
        {
            switch (context.phase)
            {
                case InputActionPhase.Started:
                    if (_controlState == EControlState.None)
                    {
                        _controlState = EControlState.MovingCamera;
                    }
                    break;
                case InputActionPhase.Canceled:
                    if (_controlState == EControlState.MovingCamera)
                    {
                        _controlState = EControlState.None;
                    }
                    break;
            }
        }

        public void DeleteClicked(InputAction.CallbackContext context)
        {
            if (_selectedPart != null)
            {
                _vehicleRoot.RemovePart(_selectedPart);
                SelectPart(null);
            }
        }
        
        public void Update()
        {
            switch (_controlState)
            {
                case EControlState.None:
                    break;
                case EControlState.DraggingGizmo:
                    _currentGizmo.UpdateDrag(_mousePosition.action.ReadValue<Vector2>(), _mouseDelta.action.ReadValue<Vector2>(), _mainCam);
                    break;
                case EControlState.MovingCamera:
                    Vector2 delta = _mouseDelta.action.ReadValue<Vector2>();
                    float verticalMove = -delta.y * _cameraMoveSpeed;
                    float rotate = delta.x * _cameraRotateSpeed;
                    _mainCam.transform.position += new Vector3(0, verticalMove * Time.deltaTime, 0.0f);
                    _mainCam.transform.RotateAround(Vector3.zero, Vector3.up, rotate * Time.deltaTime);
                    break;
            }
        }
        
        private void SelectPart(PartBase part)
        {
            _selectedPart = part;

            if (_selectedPart != null)
            {
                _currentGizmo.gameObject.SetActive(true);
                _currentGizmo.AttachToPart(_selectedPart, _vehicleRoot);
                _partInfoPanel.SetPart(_selectedPart);
            }
            else
            {
                _moveGizmo.gameObject.SetActive(false);
                _partInfoPanel.SetPart(null);
            }
        }
        
        private string GetSaveFolder()
        {
#if UNITY_EDITOR
            return Path.Combine(Application.streamingAssetsPath, "Vehicles");
#else
            return Path.Combine(Application.persistentDataPath, "Vehicles");
#endif
        }

        public void SavePressed(InputAction.CallbackContext context)
        {
            if (context.phase != InputActionPhase.Performed)
            {
                return;
            }
            
            string fileName = context.control.displayName;
            string folder = GetSaveFolder();
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            
            string path = Path.Combine(GetSaveFolder(), $"{fileName}.veh");
            _vehicleRoot.Serialise(path);
        }

        public void LoadPressed(InputAction.CallbackContext context)
        {
            if (context.phase != InputActionPhase.Performed)
            {
                return;
            }
            
            SelectPart(null);
            string fileName = context.control.displayName;
            string path = Path.Combine(GetSaveFolder(), $"{fileName}.veh");
            if (!File.Exists(path))
            {
                Debug.Log($"Can't load {path} - file doesn't exist");
                return;
            }
            Debug.Log($"Loading from {path}");
            _vehicleRoot.Deserialise(path);
        }
    }
}