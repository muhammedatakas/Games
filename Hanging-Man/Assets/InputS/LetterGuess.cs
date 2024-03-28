//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/InputS/LetterGuess.inputactions
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

public partial class @LetterGuess: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @LetterGuess()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""LetterGuess"",
    ""maps"": [
        {
            ""name"": ""GameManager"",
            ""id"": ""91ca8ab5-836b-4c90-aa46-6a1e9412098b"",
            ""actions"": [
                {
                    ""name"": ""Guess"",
                    ""type"": ""Button"",
                    ""id"": ""12cea23e-9ada-40d0-98e2-c68fc4f6b045"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b5e72e9c-cc48-4434-a193-d3f7d79295e0"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Guess"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GameManager
        m_GameManager = asset.FindActionMap("GameManager", throwIfNotFound: true);
        m_GameManager_Guess = m_GameManager.FindAction("Guess", throwIfNotFound: true);
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

    // GameManager
    private readonly InputActionMap m_GameManager;
    private List<IGameManagerActions> m_GameManagerActionsCallbackInterfaces = new List<IGameManagerActions>();
    private readonly InputAction m_GameManager_Guess;
    public struct GameManagerActions
    {
        private @LetterGuess m_Wrapper;
        public GameManagerActions(@LetterGuess wrapper) { m_Wrapper = wrapper; }
        public InputAction @Guess => m_Wrapper.m_GameManager_Guess;
        public InputActionMap Get() { return m_Wrapper.m_GameManager; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameManagerActions set) { return set.Get(); }
        public void AddCallbacks(IGameManagerActions instance)
        {
            if (instance == null || m_Wrapper.m_GameManagerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GameManagerActionsCallbackInterfaces.Add(instance);
            @Guess.started += instance.OnGuess;
            @Guess.performed += instance.OnGuess;
            @Guess.canceled += instance.OnGuess;
        }

        private void UnregisterCallbacks(IGameManagerActions instance)
        {
            @Guess.started -= instance.OnGuess;
            @Guess.performed -= instance.OnGuess;
            @Guess.canceled -= instance.OnGuess;
        }

        public void RemoveCallbacks(IGameManagerActions instance)
        {
            if (m_Wrapper.m_GameManagerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGameManagerActions instance)
        {
            foreach (var item in m_Wrapper.m_GameManagerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GameManagerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GameManagerActions @GameManager => new GameManagerActions(this);
    public interface IGameManagerActions
    {
        void OnGuess(InputAction.CallbackContext context);
    }
}
