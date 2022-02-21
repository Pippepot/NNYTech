using System;
using System.IO;
using UnityEngine;
using UnityEditor;


[InitializeOnLoad]
public static class HierachyColorHeader
{
    static HierachyColorHeader()
    {
        EditorApplication.hierarchyWindowItemOnGUI += HierarchyWindowItemOnGUI;
    }

    static void HierarchyWindowItemOnGUI(int instanceID, Rect selectionRect)
    {
        var gameObject = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

        if (gameObject != null && gameObject.name.StartsWith("Challenge", System.StringComparison.Ordinal))
        {
            Color color = new Color(0.8f, 0, 0);

            string path = Application.persistentDataPath + "/Progress.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (gameObject.GetComponent(Type.GetType(lines[i] + ",Assembly-CSharp")) != null)
                    {
                        color = new Color(0f, 0.9f, 0);
                    }
                }
            }
            
            if (gameObject.activeSelf == false)
                color.a = 0.4f;

            
            EditorGUI.DrawRect(selectionRect, color);
            EditorGUI.DropShadowLabel(selectionRect, gameObject.name.Replace("/", "").ToUpperInvariant());
        }
    }
}