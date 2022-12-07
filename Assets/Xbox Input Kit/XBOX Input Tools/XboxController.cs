using UnityEngine;
using System;
[Serializable]
public class XboxController 
{
    [SerializeField]
    int playerIndex;
    [SerializeField]
    float LeftStickX = 0;
    [SerializeField]
    float LeftStickY = 0;
    [SerializeField]
    float RightStickX = 0;
    [SerializeField]
    float RightStickY = 0;
    [SerializeField]
    float DPadX = 0;
    [SerializeField]
    float DPadY = 0;
    [SerializeField]
    float LeftTrigger = 0;
    [SerializeField]
    float RightTrigger = 0;
    [SerializeField]
    float DualTrigger = 0;

    public enum ButtonState { 
        /// <summary>
        /// The first frame a button is pressed
        /// </summary>
        isPressed, 
        /// <summary>
        /// While a button is held down
        /// </summary>
        isHolding, 
        /// <summary>
        /// The first frame after a button is let go
        /// </summary>
        isReleased, 
        /// <summary>
        /// The button is currently not pressed
        /// </summary>
        isReady };
    [SerializeField]
    ButtonState AButton = ButtonState.isReady;
    [SerializeField]
    ButtonState BButton = ButtonState.isReady;
    [SerializeField]
    ButtonState XButton = ButtonState.isReady;
    [SerializeField]
    ButtonState YButton = ButtonState.isReady;
    [SerializeField]
    ButtonState LeftBumper = ButtonState.isReady;
    [SerializeField]
    ButtonState RightBumper = ButtonState.isReady;
    [SerializeField]
    ButtonState BackButton = ButtonState.isReady;
    [SerializeField]
    ButtonState StartButton = ButtonState.isReady;
    /// <summary>
    /// Pressing in on the left analog stick
    /// </summary>
    [SerializeField]
    ButtonState LeftStickButton = ButtonState.isReady;
    /// <summary>
    /// Pressing in on the right analog stick
    /// </summary>
    [SerializeField]
    ButtonState RightStickButton = ButtonState.isReady;

    public void SetPlayerIndex(int index)
    {
        playerIndex = index;
    }
    public void SetLeftStickX(float value)
    {
        LeftStickX = value;
    }
    public void SetLeftStickY(float value)
    {
        LeftStickY = value;
    }
    public void SetRightStickX(float value)
    {
        RightStickX = value;
    }
    public void SetRightStickY(float value)
    {
        RightStickY = value;
    }
    public void SetDPadX(float value)
    {
        DPadX = value;
    }
    public void SetDPadY(float value)
    {
        DPadY = value;
    }
    public void SetLeftTrigger(float value)
    {
        LeftTrigger = value;
    }
    public void SetRightTrigger(float value)
    {
        RightTrigger = value;
    }
    public void SetDualTrigger(float value)
    {
        DualTrigger = value;
    }
    public int GetPlayerIndex()
    {
       return playerIndex ;
    }
    public float GetLeftStickX()
    {
        return LeftStickX ;
    }
    public float GetLeftStickY()
    {
        return LeftStickY ;
    }
    public float GetRightStickX()
    {
        return RightStickX ;
    }
    public float GetRightStickY()
    {
        return RightStickY ;
    }
    public float GetDPadX()
    {
        return DPadX ;
    }
    public float GetDPadY()
    {
        return DPadY ;
    }
    public float GetLeftTrigger()
    {
        return LeftTrigger ;
    }
    public float GetRightTrigger()
    {
        return RightTrigger ;
    }
    public float GetDualTrigger()
    {
        return DualTrigger ;
    }
    public ButtonState GetButtonAState()
    {
        return AButton ;
    }
    public ButtonState GetButtonBState()
    {
        return BButton ;
    }
    public ButtonState GetButtonXState()
    {
        return XButton ;
    }
    public ButtonState GetButtonYState()
    {
        return YButton ;
    }
    public ButtonState GetButtonBackState()
    {
        return BackButton ;
    }
    public ButtonState GetButtonStartState()
    {
        return StartButton ;
    }
    public ButtonState GetLeftBumperState()
    {
        return LeftBumper ;
    }
    public ButtonState GetRightBumperState()
    {
        return RightBumper ;
    }
    public ButtonState GetLeftStickState()
    {
        return LeftStickButton ;
    }
    public ButtonState GetRightStickState()
    {
       return RightStickButton ;
    }
    public void SetButtonAState(ButtonState b)
    {
        AButton = b;
    }
    public void SetButtonBState(ButtonState b)
    {
        BButton = b;
    }
    public void SetButtonXState(ButtonState b)
    {
        XButton = b;
    }
    public void SetButtonYState(ButtonState b)
    {
        YButton = b;
    }
    public void SetButtonBackState(ButtonState b)
    {
        BackButton = b;
    }
    public void SetButtonStartState(ButtonState b)
    {
        StartButton = b;
    }
    public void SetLeftBumperState(ButtonState b)
    {
        LeftBumper = b;
    }
    public void SetRightBumperState(ButtonState b)
    {
        RightBumper = b;
    }
    public void SetLeftStickState(ButtonState b)
    {
        LeftStickButton = b;
    }
    public void SetRightStickState(ButtonState b)
    {
        RightStickButton = b;
    }

    public XboxController(int index)
    {
        playerIndex = index;
    }
}
