using DataTypes;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Input.Manager
{
    public class InputManager : MonoBehaviour
    {
        [Header("Movement Data")]
        [SerializeField] private Vector2Ref movementData;
        [SerializeField] private BoolRef isMoving;

        [Header("Mouse Data")] 
        [SerializeField] private Vector2Ref mousePosition;
        
        private InputMap _input;

        #region MonoBehaviours

        private void Awake()
        {
            _input = new InputMap();
        }

        private void OnEnable()
        {
            _input.Gameplay.Move.Enable();
            _input.Gameplay.Move.started += OnMovementInput;
            _input.Gameplay.Move.performed += OnMovementInput;
            _input.Gameplay.Move.canceled += OnMovementInput;
            
            _input.Mouse.Position.Enable();
            _input.Mouse.Position.started += GetMousePosition;
            _input.Mouse.Position.performed += GetMousePosition;
            _input.Mouse.Position.canceled += GetMousePosition;
        }

        private void OnDisable()
        {
            _input.Gameplay.Move.Disable();
            
            _input.Mouse.Position.Disable();
        }

        #endregion


        #region Input Handling

        private void OnMovementInput(InputAction.CallbackContext context)
        {
            movementData.Value = context.ReadValue<Vector2>();
            isMoving.Value = context.ReadValue<Vector2>().magnitude != 0;
        }

        private void GetMousePosition(InputAction.CallbackContext context)
        {
            mousePosition.Value = Cache.MainCamera.ScreenToWorldPoint(context.ReadValue<Vector2>());
        }
        #endregion
    }
}