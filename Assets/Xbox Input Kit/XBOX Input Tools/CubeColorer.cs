using UnityEngine;
//This script tests the first two controllers connected and displays a color on a cube
//based on which player pressed a button, as well as which button was pressed.
//It does not respond to axes, only buttons, so that means the triggers will have no effect.
public class CubeColorer : MonoBehaviour
{
    Renderer rend;
    Material mat;
    public Color[] reds;
    public Color[] blues;
    void Start()
    {
        rend = GetComponent<Renderer>();
        mat = rend.material;
        reds = new Color[10];
        blues = new Color[10];
        for (int i=0;i<blues.Length;++i)
        {
            blues[i] = new Color(0,0,i / 10f, 1);
        }
        for (int i = 0; i < reds.Length; ++i)
        {
            reds[i] = new Color( i / 10f, 0, 0, 1);
        }
    }

    void Update()
    {
        //This tests the first two controllers connected and displays a color on a cube
        //based on which player pressed a button, as well as which button was pressed.
        if (InputManager.controllers[0].GetButtonAState() == XboxController.ButtonState.isPressed)
            mat.color = blues[0];
        if (InputManager.controllers[0].GetButtonBState() == XboxController.ButtonState.isPressed)
            mat.color = blues[1];
        if (InputManager.controllers[0].GetButtonXState() == XboxController.ButtonState.isPressed)
            mat.color = blues[2];
        if (InputManager.controllers[0].GetButtonYState() == XboxController.ButtonState.isPressed)
            mat.color = blues[3];
        if (InputManager.controllers[0].GetLeftBumperState() == XboxController.ButtonState.isPressed)
            mat.color = blues[4];
        if (InputManager.controllers[0].GetRightBumperState() == XboxController.ButtonState.isPressed)
            mat.color = blues[5];
        if (InputManager.controllers[0].GetButtonBackState() == XboxController.ButtonState.isPressed)
            mat.color = blues[6];
        if (InputManager.controllers[0].GetButtonStartState() == XboxController.ButtonState.isPressed)
            mat.color = blues[7];
        if (InputManager.controllers[0].GetLeftStickState() == XboxController.ButtonState.isPressed)
            mat.color = blues[8];
        if (InputManager.controllers[0].GetRightStickState() == XboxController.ButtonState.isPressed)
            mat.color = blues[9];


        if (InputManager.controllers[1].GetButtonAState() == XboxController.ButtonState.isPressed)
            mat.color = reds[0];
        if (InputManager.controllers[1].GetButtonBState() == XboxController.ButtonState.isPressed)
            mat.color = reds[1];
        if (InputManager.controllers[1].GetButtonXState() == XboxController.ButtonState.isPressed)
            mat.color = reds[2];
        if (InputManager.controllers[1].GetButtonYState() == XboxController.ButtonState.isPressed)
            mat.color = reds[3];
        if (InputManager.controllers[1].GetLeftBumperState() == XboxController.ButtonState.isPressed)
            mat.color = reds[4];
        if (InputManager.controllers[1].GetRightBumperState() == XboxController.ButtonState.isPressed)
            mat.color = reds[5];
        if (InputManager.controllers[1].GetButtonBackState() == XboxController.ButtonState.isPressed)
            mat.color = reds[6];
        if (InputManager.controllers[1].GetButtonStartState() == XboxController.ButtonState.isPressed)
            mat.color = reds[7];
        if (InputManager.controllers[1].GetLeftStickState() == XboxController.ButtonState.isPressed)
            mat.color = reds[8];
        if (InputManager.controllers[1].GetRightStickState() == XboxController.ButtonState.isPressed)
            mat.color = reds[9];
    }
}
