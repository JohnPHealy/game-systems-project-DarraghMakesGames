// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""DefaultPlayer"",
            ""id"": ""49a663b6-27d0-4ab6-97b2-697c648aa087"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0fc00333-a86c-4ea6-b04d-f95b9db0d09f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""60338f88-f1d3-4556-a441-c3dd58c7fc3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6d218218-b562-45fb-8cb0-385e6d4cf4ce"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0a069037-cad1-40a1-af58-f84c49fc291e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""DropItem"",
                    ""type"": ""Button"",
                    ""id"": ""1c42e70d-e271-4f5f-9db6-578129593d5a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Examine"",
                    ""type"": ""Button"",
                    ""id"": ""b8065ab8-3066-43cf-9311-83f09cd8ab42"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""a31eca6f-6ceb-46a1-8249-18815281ab8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CheatAddGold"",
                    ""type"": ""Button"",
                    ""id"": ""ef07afe2-779f-40e2-a757-660b1a9b7536"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f3b0f417-20cc-4c64-8ff0-790ac451b310"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d4566c9c-4236-48d4-953b-d9e95a1942f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""11136ee7-caab-4152-a022-2b0714370b0f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c99969e4-7a6a-4f9a-a0f7-6b826e746fca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a49d9cd4-ffbd-4078-b2e6-e2cf5e26dd00"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""53ae58a0-b323-49aa-aff7-2ba074b78735"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""166c72f5-70fd-4764-8d2b-e34e87c4e507"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8237ef6d-bbf8-4cfe-b5db-e53d9fe03633"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3c209c8-e3dc-48c2-bc22-646267a29422"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DropItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8d2e276e-284f-406d-9471-e35f2a2cee90"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Examine"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e6bbef0-7383-4c23-95bd-605d00f51dbd"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9746ec8-a57b-425f-98d8-65312a85ea11"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77a1422b-c71d-4875-9981-b8220949c054"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""CheatAddGold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // DefaultPlayer
        m_DefaultPlayer = asset.FindActionMap("DefaultPlayer", throwIfNotFound: true);
        m_DefaultPlayer_Movement = m_DefaultPlayer.FindAction("Movement", throwIfNotFound: true);
        m_DefaultPlayer_Jump = m_DefaultPlayer.FindAction("Jump", throwIfNotFound: true);
        m_DefaultPlayer_Look = m_DefaultPlayer.FindAction("Look", throwIfNotFound: true);
        m_DefaultPlayer_Interact = m_DefaultPlayer.FindAction("Interact", throwIfNotFound: true);
        m_DefaultPlayer_DropItem = m_DefaultPlayer.FindAction("DropItem", throwIfNotFound: true);
        m_DefaultPlayer_Examine = m_DefaultPlayer.FindAction("Examine", throwIfNotFound: true);
        m_DefaultPlayer_Pause = m_DefaultPlayer.FindAction("Pause", throwIfNotFound: true);
        m_DefaultPlayer_CheatAddGold = m_DefaultPlayer.FindAction("CheatAddGold", throwIfNotFound: true);
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

    // DefaultPlayer
    private readonly InputActionMap m_DefaultPlayer;
    private IDefaultPlayerActions m_DefaultPlayerActionsCallbackInterface;
    private readonly InputAction m_DefaultPlayer_Movement;
    private readonly InputAction m_DefaultPlayer_Jump;
    private readonly InputAction m_DefaultPlayer_Look;
    private readonly InputAction m_DefaultPlayer_Interact;
    private readonly InputAction m_DefaultPlayer_DropItem;
    private readonly InputAction m_DefaultPlayer_Examine;
    private readonly InputAction m_DefaultPlayer_Pause;
    private readonly InputAction m_DefaultPlayer_CheatAddGold;
    public struct DefaultPlayerActions
    {
        private @PlayerControls m_Wrapper;
        public DefaultPlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_DefaultPlayer_Movement;
        public InputAction @Jump => m_Wrapper.m_DefaultPlayer_Jump;
        public InputAction @Look => m_Wrapper.m_DefaultPlayer_Look;
        public InputAction @Interact => m_Wrapper.m_DefaultPlayer_Interact;
        public InputAction @DropItem => m_Wrapper.m_DefaultPlayer_DropItem;
        public InputAction @Examine => m_Wrapper.m_DefaultPlayer_Examine;
        public InputAction @Pause => m_Wrapper.m_DefaultPlayer_Pause;
        public InputAction @CheatAddGold => m_Wrapper.m_DefaultPlayer_CheatAddGold;
        public InputActionMap Get() { return m_Wrapper.m_DefaultPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IDefaultPlayerActions instance)
        {
            if (m_Wrapper.m_DefaultPlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnLook;
                @Interact.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnInteract;
                @DropItem.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnDropItem;
                @DropItem.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnDropItem;
                @DropItem.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnDropItem;
                @Examine.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnExamine;
                @Examine.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnExamine;
                @Examine.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnExamine;
                @Pause.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnPause;
                @CheatAddGold.started -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnCheatAddGold;
                @CheatAddGold.performed -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnCheatAddGold;
                @CheatAddGold.canceled -= m_Wrapper.m_DefaultPlayerActionsCallbackInterface.OnCheatAddGold;
            }
            m_Wrapper.m_DefaultPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @DropItem.started += instance.OnDropItem;
                @DropItem.performed += instance.OnDropItem;
                @DropItem.canceled += instance.OnDropItem;
                @Examine.started += instance.OnExamine;
                @Examine.performed += instance.OnExamine;
                @Examine.canceled += instance.OnExamine;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @CheatAddGold.started += instance.OnCheatAddGold;
                @CheatAddGold.performed += instance.OnCheatAddGold;
                @CheatAddGold.canceled += instance.OnCheatAddGold;
            }
        }
    }
    public DefaultPlayerActions @DefaultPlayer => new DefaultPlayerActions(this);
    public interface IDefaultPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnDropItem(InputAction.CallbackContext context);
        void OnExamine(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnCheatAddGold(InputAction.CallbackContext context);
    }
}
