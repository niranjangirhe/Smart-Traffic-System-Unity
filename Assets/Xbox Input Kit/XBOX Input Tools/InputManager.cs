using UnityEngine;

public static class InputManager
{
    public static XboxController[] controllers;
    static KeyCode[][] keyCodes;
    public static void Initialize() { 
        controllers = new XboxController[8];
        for (int i = 0; i < 8; ++i)
            controllers[i] = new XboxController(i + 1);

        keyCodes = new KeyCode[8][];
        keyCodes[0] = new KeyCode[] { KeyCode.Joystick1Button0, KeyCode.Joystick1Button1, KeyCode.Joystick1Button2, KeyCode.Joystick1Button3, KeyCode.Joystick1Button4, KeyCode.Joystick1Button5, KeyCode.Joystick1Button6, KeyCode.Joystick1Button7, KeyCode.Joystick1Button8, KeyCode.Joystick1Button9 };
        keyCodes[1] = new KeyCode[] { KeyCode.Joystick2Button0, KeyCode.Joystick2Button1, KeyCode.Joystick2Button2, KeyCode.Joystick2Button3, KeyCode.Joystick2Button4, KeyCode.Joystick2Button5, KeyCode.Joystick2Button6, KeyCode.Joystick2Button7, KeyCode.Joystick2Button8, KeyCode.Joystick2Button9 };
        keyCodes[2] = new KeyCode[] { KeyCode.Joystick3Button0, KeyCode.Joystick3Button1, KeyCode.Joystick3Button2, KeyCode.Joystick3Button3, KeyCode.Joystick3Button4, KeyCode.Joystick3Button5, KeyCode.Joystick3Button6, KeyCode.Joystick3Button7, KeyCode.Joystick3Button8, KeyCode.Joystick3Button9 };
        keyCodes[3] = new KeyCode[] { KeyCode.Joystick4Button0, KeyCode.Joystick4Button1, KeyCode.Joystick4Button2, KeyCode.Joystick4Button3, KeyCode.Joystick4Button4, KeyCode.Joystick4Button5, KeyCode.Joystick4Button6, KeyCode.Joystick4Button7, KeyCode.Joystick4Button8, KeyCode.Joystick4Button9 };
        keyCodes[4] = new KeyCode[] { KeyCode.Joystick5Button0, KeyCode.Joystick5Button1, KeyCode.Joystick5Button2, KeyCode.Joystick5Button3, KeyCode.Joystick5Button4, KeyCode.Joystick5Button5, KeyCode.Joystick5Button6, KeyCode.Joystick5Button7, KeyCode.Joystick5Button8, KeyCode.Joystick5Button9 };
        keyCodes[5] = new KeyCode[] { KeyCode.Joystick6Button0, KeyCode.Joystick6Button1, KeyCode.Joystick6Button2, KeyCode.Joystick6Button3, KeyCode.Joystick6Button4, KeyCode.Joystick6Button5, KeyCode.Joystick6Button6, KeyCode.Joystick6Button7, KeyCode.Joystick6Button8, KeyCode.Joystick6Button9 };
        keyCodes[6] = new KeyCode[] { KeyCode.Joystick7Button0, KeyCode.Joystick7Button1, KeyCode.Joystick7Button2, KeyCode.Joystick7Button3, KeyCode.Joystick7Button4, KeyCode.Joystick7Button5, KeyCode.Joystick7Button6, KeyCode.Joystick7Button7, KeyCode.Joystick7Button8, KeyCode.Joystick7Button9 };
        keyCodes[7] = new KeyCode[] { KeyCode.Joystick8Button0, KeyCode.Joystick8Button1, KeyCode.Joystick8Button2, KeyCode.Joystick8Button3, KeyCode.Joystick8Button4, KeyCode.Joystick8Button5, KeyCode.Joystick8Button6, KeyCode.Joystick8Button7, KeyCode.Joystick8Button8, KeyCode.Joystick8Button9 };
    }
    public static void UpdateControllers()
    {
        for (int i = 0; i < keyCodes.Length; ++i)
        {
            UpdateController(i + 1);
        }
    }
    private static void UpdateController(int playerIndex)
    {
        XboxController current = controllers[playerIndex - 1];
        current.SetLeftStickX(Input.GetAxis("LeftStickX" + playerIndex));
        current.SetLeftStickY(-1f * Input.GetAxis("LeftStickY" + playerIndex));
        current.SetRightStickX(Input.GetAxis("RightStickX" + playerIndex));
        current.SetRightStickY(-1f * Input.GetAxis("RightStickY" + playerIndex));
        current.SetDPadX(Input.GetAxis("DPadX" + playerIndex));
        current.SetDPadY(Input.GetAxis("DPadY" + playerIndex));
        current.SetLeftTrigger(Input.GetAxis("LeftTrigger" + playerIndex));
        current.SetRightTrigger(Input.GetAxis("RightTrigger" + playerIndex));
        current.SetDualTrigger(Input.GetAxis("DualTrigger" + playerIndex));

        KeyCode[] codes = keyCodes[playerIndex - 1];
        if (Input.GetKeyDown(codes[0]))
        {
            current.SetButtonAState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[0]))
        {
            current.SetButtonAState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[0]))
        {
            current.SetButtonAState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetButtonAState(XboxController.ButtonState.isReady);
        if (Input.GetKeyDown(codes[1]))
        {
            current.SetButtonBState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[1]))
        {
            current.SetButtonBState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[1]))
        {
            current.SetButtonBState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetButtonBState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[2]))
        {
            current.SetButtonXState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[2]))
        {
            current.SetButtonXState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[2]))
        {
            current.SetButtonXState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetButtonXState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[3]))
        {
            current.SetButtonYState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[3]))
        {
            current.SetButtonYState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[3]))
        {
            current.SetButtonYState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetButtonYState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[4]))
        {
            current.SetLeftBumperState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[4]))
        {
            current.SetLeftBumperState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[4]))
        {
            current.SetLeftBumperState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetLeftBumperState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[5]))
        {
            current.SetRightBumperState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[5]))
        {
            current.SetRightBumperState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[5]))
        {
            current.SetRightBumperState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetRightBumperState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[6]))
        {
            current.SetButtonBackState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[6]))
        {
            current.SetButtonBackState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[6]))
        {
            current.SetButtonBackState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetButtonBackState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[7]))
        {
            current.SetButtonStartState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[7]))
        {
            current.SetButtonStartState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[7]))
        {
            current.SetButtonStartState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetButtonStartState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[8]))
        {
            current.SetLeftStickState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[8]))
        {
            current.SetLeftStickState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[8]))
        {
            current.SetLeftStickState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetLeftStickState(XboxController.ButtonState.isReady);

        if (Input.GetKeyDown(codes[9]))
        {
            current.SetRightStickState(XboxController.ButtonState.isPressed);
        }
        else if (Input.GetKey(codes[9]))
        {
            current.SetRightStickState(XboxController.ButtonState.isHolding);
        }
        else if (Input.GetKeyUp(codes[9]))
        {
            current.SetRightStickState(XboxController.ButtonState.isReleased);
        }
        else
            current.SetRightStickState(XboxController.ButtonState.isReady);
    }
}
