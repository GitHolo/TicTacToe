using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyWindow : EditorWindow
{
    [MenuItem("Window/Moje okienko")]
    public static void OpenWindow()
    {
        GetWindow<MyWindow>();
    }
}
