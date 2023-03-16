using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VisualDialogos : EditorWindow
{
    [MenuItem("Window/Dialogo")]
    public static void CreateMenu()
    {
        EditorWindow Window = EditorWindow.GetWindow<VisualDialogos>();
        Window.titleContent = new GUIContent("Dialogos");
    }

    private void OnGUI()
    {
        



    }

}
