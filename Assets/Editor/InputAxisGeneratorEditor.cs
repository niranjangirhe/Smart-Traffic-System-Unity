using UnityEngine;
using UnityEditor;
[CustomEditor(typeof(InputAxisGenerator))]
public class InputAxisGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        InputAxisGenerator myTarget = (InputAxisGenerator)target;
        DrawDefaultInspector();
        if (GUILayout.Button("Generate Custom Axes"))
        {
            myTarget.GenerateMoreAxes();
        }
        if (GUILayout.Button("Generate Recommended XBOX Axes"))
        {
            myTarget.GenerateXBOXAxes();
        }
    }
}
