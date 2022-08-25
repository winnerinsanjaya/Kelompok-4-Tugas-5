//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/InputActionManager.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActionManager : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActionManager()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActionManager"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""ed41f4bc-dbf3-44ab-9cf9-9a5e1469c595"",
            ""actions"": [
                {
                    ""name"": ""Player1"",
                    ""type"": ""Button"",
                    ""id"": ""8e35f870-4d49-44cd-a45c-56f3276169ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Player2"",
                    ""type"": ""Button"",
                    ""id"": ""52b78f0e-a445-4c5a-aefa-5547ce00504c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7edac8a7-75cc-4eec-965c-792f9acfb109"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a573f0a6-5906-4994-91d0-23ecd0336742"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64ffda27-f05c-4348-86a5-b19c0dee56db"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""639c1f51-33eb-4d74-9231-79ac6ec35d10"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3291b1af-96bd-495e-9fa1-7efbc16b2cb8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""df0d69f0-bac3-40f4-b015-3d3f4287590f"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad7bb011-b27f-4102-bd7e-0e7acba86d6d"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e5c4320d-e56d-43ea-b999-d6c78addcf11"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Player1 = m_Move.FindAction("Player1", throwIfNotFound: true);
        m_Move_Player2 = m_Move.FindAction("Player2", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Move
    private readonly InputActionMap m_Move;
    private IMoveActions m_MoveActionsCallbackInterface;
    private readonly InputAction m_Move_Player1;
    private readonly InputAction m_Move_Player2;
    public struct MoveActions
    {
        private @InputActionManager m_Wrapper;
        public MoveActions(@InputActionManager wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1 => m_Wrapper.m_Move_Player1;
        public InputAction @Player2 => m_Wrapper.m_Move_Player2;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void SetCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterface != null)
            {
                @Player1.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnPlayer1;
                @Player1.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnPlayer1;
                @Player1.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnPlayer1;
                @Player2.started -= m_Wrapper.m_MoveActionsCallbackInterface.OnPlayer2;
                @Player2.performed -= m_Wrapper.m_MoveActionsCallbackInterface.OnPlayer2;
                @Player2.canceled -= m_Wrapper.m_MoveActionsCallbackInterface.OnPlayer2;
            }
            m_Wrapper.m_MoveActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Player1.started += instance.OnPlayer1;
                @Player1.performed += instance.OnPlayer1;
                @Player1.canceled += instance.OnPlayer1;
                @Player2.started += instance.OnPlayer2;
                @Player2.performed += instance.OnPlayer2;
                @Player2.canceled += instance.OnPlayer2;
            }
        }
    }
    public MoveActions @Move => new MoveActions(this);
    public interface IMoveActions
    {
        void OnPlayer1(InputAction.CallbackContext context);
        void OnPlayer2(InputAction.CallbackContext context);
    }
}
