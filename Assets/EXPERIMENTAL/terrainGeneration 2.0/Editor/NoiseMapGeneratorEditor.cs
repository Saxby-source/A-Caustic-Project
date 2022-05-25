using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(NoiseMapGenerator))]
public class NoiseMapGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        NoiseMapGenerator mapGenerator = (NoiseMapGenerator)target;

        if (DrawDefaultInspector())
        {
            if (mapGenerator.autoUpdate)
            {
                mapGenerator.GenerateMap();
            }
        }

        if (GUILayout.Button ("Generate"))
        {
            mapGenerator.GenerateMap();
        }

    }
}
