// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Controls : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""da5477e7-d16f-4cc6-9c05-5f5728a5541b"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b29500f9-0fab-445a-986d-e3694c613f02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pausar"",
                    ""type"": ""Button"",
                    ""id"": ""446aebef-a584-49da-a888-b386e70f8eb5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""d0cf0903-1bbe-482c-8a95-4737d3769f92"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quit"",
                    ""type"": ""Button"",
                    ""id"": ""a3ffbd20-14ea-419e-bd58-bcf30134604f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""b1c7e445-be2a-4c44-aa52-532451a073c1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Resume"",
                    ""type"": ""Button"",
                    ""id"": ""0cbb16ab-0ab0-465e-ad9f-aaae2cb37cb2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""258bab61-9411-42f2-a2e9-7b294b6616a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""Value"",
                    ""id"": ""9b82cece-315f-4965-b0a0-652359857e70"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8a07e49c-35db-42b1-9e3f-87499cd01669"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Generic"",
                    ""id"": ""862c57dd-9dc0-499c-ba95-90e67068b787"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""49dc8ddd-5169-45d2-9459-455a52eefc15"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6d175024-3976-431a-97b4-dd7b7e66b0ea"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""00080564-f50c-4697-8b2d-1450d28bb232"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d60c71e0-2317-4310-a2b2-2f616182081e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1709c738-562f-43de-9c7c-7b33397d44b8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""52378a20-0da9-498a-ba51-d5b59b1917ec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f457b43-f590-48bc-941c-5067ccf1e263"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5d51d049-f603-48b0-ad8e-ab54ee3eb1d2"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""57cc869d-6d2b-44b4-aa2d-02504f3cea30"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e39d767c-c753-4a39-91ab-e606e47c9b1b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9be2b19-f8a1-47db-9df6-df4b252c37ee"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gneric"",
                    ""id"": ""bb9fcb68-b2cb-4323-89ef-d90486769ec9"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""817d0d65-4599-4940-b9f3-2c8e33cc3744"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c859a643-dc72-49aa-b44e-02caf2456536"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""30f63e65-af9a-4091-b6c9-9a99fdc08e45"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6ba826e9-2483-493d-934f-ff4d06745b9e"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""GamePad"",
                    ""id"": ""e0cc1ef8-a4e7-4e49-8d9f-856d8d783135"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2478e6ef-0fdf-4d8f-aa05-3ee906d09418"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c1bf362a-5114-46aa-bb8e-498fe22fed6c"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12714020-d71d-43f4-9213-020d21265c85"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""22e7d066-691a-4dbe-8973-f25ca0c3d520"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c1b99572-92e1-47b7-b0bb-e4a24a0ce770"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""48ccc399-8d5a-4420-9b35-ddff32dc5b7c"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""186e3a7c-b9c2-47e4-8b6e-e16eee05a36d"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""81eb0bfb-b684-4525-a4a6-dacb864f00ea"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Resume"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9db1fce8-66fe-410b-8efa-bcefc91e8493"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3d8df721-365f-4d50-ad64-e656088c57c1"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be8e5ab9-0277-43d5-b2e6-9662393f2498"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a46c070b-ebe5-44b5-a84e-71b879e3ad31"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79b4250a-a35b-4720-a475-9531a84ede44"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db8de406-b4df-457d-8ad1-a68c0e86f925"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02d7d4e5-a743-4349-b502-19672a4a9c9c"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pausar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26a641a1-46eb-4fc3-8078-949cb76430e9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pausar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""b9d11ad8-bf1d-43ae-abdd-6ebf9a52ac0a"",
            ""actions"": [
                {
                    ""name"": ""Start"",
                    ""type"": ""Button"",
                    ""id"": ""9edabbae-1a31-481a-bbc7-d4095c201480"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2ae70cb5-7a6d-4cc9-afa1-996bd6297f53"",
                    ""path"": ""<HID::DragonRise Inc.   Generic   USB  Joystick  >/button10"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""598e5d0e-6c76-457f-84b7-217f85b73d65"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d46fcfb4-00a4-4d5f-94c2-3c532eb3ec68"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Walk = m_Player.FindAction("Walk", throwIfNotFound: true);
        m_Player_Pausar = m_Player.FindAction("Pausar", throwIfNotFound: true);
        m_Player_Restart = m_Player.FindAction("Restart", throwIfNotFound: true);
        m_Player_Quit = m_Player.FindAction("Quit", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
        m_Player_Resume = m_Player.FindAction("Resume", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Point = m_Player.FindAction("Point", throwIfNotFound: true);
        m_Player_Shoot = m_Player.FindAction("Shoot", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_Start = m_Menu.FindAction("Start", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Walk;
    private readonly InputAction m_Player_Pausar;
    private readonly InputAction m_Player_Restart;
    private readonly InputAction m_Player_Quit;
    private readonly InputAction m_Player_Menu;
    private readonly InputAction m_Player_Resume;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Point;
    private readonly InputAction m_Player_Shoot;
    public struct PlayerActions
    {
        private Controls m_Wrapper;
        public PlayerActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Player_Walk;
        public InputAction @Pausar => m_Wrapper.m_Player_Pausar;
        public InputAction @Restart => m_Wrapper.m_Player_Restart;
        public InputAction @Quit => m_Wrapper.m_Player_Quit;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputAction @Resume => m_Wrapper.m_Player_Resume;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Point => m_Wrapper.m_Player_Point;
        public InputAction @Shoot => m_Wrapper.m_Player_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Walk.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                Walk.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                Walk.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalk;
                Pausar.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPausar;
                Pausar.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPausar;
                Pausar.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPausar;
                Restart.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestart;
                Restart.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestart;
                Restart.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRestart;
                Quit.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuit;
                Quit.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuit;
                Quit.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnQuit;
                Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                Resume.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                Resume.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                Resume.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnResume;
                Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Point.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPoint;
                Point.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPoint;
                Point.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPoint;
                Shoot.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Walk.started += instance.OnWalk;
                Walk.performed += instance.OnWalk;
                Walk.canceled += instance.OnWalk;
                Pausar.started += instance.OnPausar;
                Pausar.performed += instance.OnPausar;
                Pausar.canceled += instance.OnPausar;
                Restart.started += instance.OnRestart;
                Restart.performed += instance.OnRestart;
                Restart.canceled += instance.OnRestart;
                Quit.started += instance.OnQuit;
                Quit.performed += instance.OnQuit;
                Quit.canceled += instance.OnQuit;
                Menu.started += instance.OnMenu;
                Menu.performed += instance.OnMenu;
                Menu.canceled += instance.OnMenu;
                Resume.started += instance.OnResume;
                Resume.performed += instance.OnResume;
                Resume.canceled += instance.OnResume;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                Point.started += instance.OnPoint;
                Point.performed += instance.OnPoint;
                Point.canceled += instance.OnPoint;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_Start;
    public struct MenuActions
    {
        private Controls m_Wrapper;
        public MenuActions(Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Start => m_Wrapper.m_Menu_Start;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                Start.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                Start.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
                Start.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnStart;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                Start.started += instance.OnStart;
                Start.performed += instance.OnStart;
                Start.canceled += instance.OnStart;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IPlayerActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnPausar(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnResume(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnStart(InputAction.CallbackContext context);
    }
}
