using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class InputAxisGenerator : MonoBehaviour
{

    public InputManagerAxis axis;
    public void GenerateXBOXAxes()
    {
        //find the path to assets folder, then add the necessary directory to get to the input 
        //manager asset file
        System.IO.DirectoryInfo dInfo = System.IO.Directory.GetParent(Application.dataPath);
        //You can use the debug below to verify it is finding the assets folder correctly
        //Debug.Log(dInfo.FullName);
        string path = dInfo.FullName + "/ProjectSettings/InputManager.asset";
        string[] lines = File.ReadAllLines(path);

        //Create the number of axes needed, then rewrite the input manager file with new axes
        //added to the end. This asset does NOT delete old axes, it simply adds more.
        string[] linesWithNewAxes = GenerateDefaultXboxAxes(lines);
        File.WriteAllLines(path, linesWithNewAxes);
        //You can delete old axes by going to the input manager, clicking the name of the
        //axis you want to delete, then pressing the delete key on your keyboard.
    }
    public void GenerateMoreAxes()
    {
        //find the path to assets folder, then add the necessary directory to get to the input 
        //manager asset file
        System.IO.DirectoryInfo dInfo = System.IO.Directory.GetParent(Application.dataPath);
        //You can use the debug below to verify it is finding the assets folder correctly
        //Debug.Log(dInfo.FullName);
        string path = dInfo.FullName + "/ProjectSettings/InputManager.asset";
        string[] lines = File.ReadAllLines(path);

        //Create the number of axes needed, then rewrite the input manager file with new axes
        //added to the end. This asset does NOT delete old axes, it simply adds more.
        string[] linesWithNewAxes = GenerateInputAxes(lines);
        File.WriteAllLines(path, linesWithNewAxes);
        //You can delete old axes by going to the input manager, clicking the name of the
        //axis you want to delete, then pressing the delete key on your keyboard.
    }

    string[] GenerateInputAxes(string[] lines)
    {
        for (int i = 0; i < axis.maximumNumberOfControllers; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + axis.axisName + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + axis.gravity;//0 works
            newLines[9] = "    dead: " + axis.dead;//about 0.2f works
            newLines[10] = "    sensitivity: " + axis.sensitivity;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + (int)axis.typeOfAxis;
            newLines[14] = "    axis: " + (axis.joystickAxisIndex - 1);
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        return lines;
    }
    string[] GenerateDefaultXboxAxes(string[] lines)
    {
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "LeftStickX" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 0;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "LeftStickY" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 1;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "RightStickX" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 3;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "RightStickY" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 4;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "DPadX" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 5;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "DPadY" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 6;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "LeftTrigger" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 8;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "RightTrigger" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 9;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }
        for (int i = 0; i < 8; ++i)
        {
            string[] newLines = new string[16];
            newLines[0] = "  - serializedVersion: 3";
            newLines[1] = "    m_Name: " + "DualTrigger" + (i + 1);
            newLines[2] = "    descriptiveName: ";//deprecated
            newLines[3] = "    descriptiveNegativeName: ";//deprecated
            newLines[4] = "    negativeButton: " + axis.negativeButtonName;
            newLines[5] = "    positiveButton: " + axis.positiveButtonName;
            newLines[6] = "    altNegativeButton: " + axis.altNegativeButtonName;
            newLines[7] = "    altPositiveButton: " + axis.altPositiveButtonName;
            newLines[8] = "    gravity: " + 0;//0 works
            newLines[9] = "    dead: " + 0.2f;//about 0.2f works
            newLines[10] = "    sensitivity: " + 1f;//about 1f to 3f works
            if (axis.snap)
                newLines[11] = "    snap: 1";
            else newLines[11] = "    snap: 0";
            if (axis.invert)
                newLines[12] = "    invert: 1";
            else
                newLines[12] = "    invert: 0";
            newLines[13] = "    type: " + 2;
            newLines[14] = "    axis: " + 2;
            newLines[15] = "    joyNum: " + (i + 1);

            string[] withLinesAdded = new string[lines.Length + newLines.Length];
            lines.CopyTo(withLinesAdded, 0);
            newLines.CopyTo(withLinesAdded, lines.Length);
            lines = withLinesAdded;
        }

        return lines;
    }
}
