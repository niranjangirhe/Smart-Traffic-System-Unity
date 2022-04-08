
using UnityEngine;
using System;
[Serializable]
public class InputManagerAxis 
{
    /// <summary>
    /// The name you will use in your code
    /// </summary>
    public string axisName="newAxis";
    /// <summary>
    /// The key or button you would like to designate for negative values
    /// </summary>
    public string negativeButtonName="";
    /// <summary>
    /// The key or button you would like to designate for positive values
    /// </summary>
    public string positiveButtonName="";
    /// <summary>
    /// A second key or button you would like to designate for negative values
    /// </summary>
    public string altNegativeButtonName="";
    /// <summary>
    /// A second key or button you would like to designate for positive values
    /// </summary>
    public string altPositiveButtonName="";
    /// <summary>
    /// How quickly you would like the axis to return to 0 when at rest (in units per second)
    /// </summary>
    [Range(0f,10f)]
    public float gravity=0f;
    /// <summary>
    /// The range of values to ignore to prevent accidental input
    /// </summary>
    [Range(0f,1f)]
    public float dead=0.2f;
    /// <summary>
    /// Speed in units per second to move towards target value
    /// </summary>
    [Range(0f,10f)]
    public float sensitivity=1f;
    /// <summary>
    /// True means the axis will reset to zero when pressing a button opposing the current value
    /// </summary>
    public bool snap=true;
    /// <summary>
    /// If the values from your controller are inverted, you can change this to true.
    /// </summary>
    public bool invert=false;
    public enum TypeOfAxis { keyOrMouseButton, mouseMovement, joystick };
    /// <summary>
    /// Designate the type of control used to generate axis values.
    /// </summary>
    public TypeOfAxis typeOfAxis=TypeOfAxis.joystick;
    /// <summary>
    /// The mapped axis number for your controller. 
    /// 1 for x, 2 for y, and the rest are matching the axis number.
    /// </summary>
    public int joystickAxisIndex=1;
    /// <summary>
    /// The player number for the given controller. 1 for first player, 2 for second player, etc.
    /// This value will be ignored and is here solely for descriptive purposes.
    /// </summary>
    public int joystickNumber=1;
    /// <summary>
    /// This value will determine how many axes are generated.
    /// If you need non-specific input from all joysticks, use the input manager to manually add the axis instead.
    /// </summary>
    public int maximumNumberOfControllers=1;

}
