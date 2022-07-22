using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GuidComponent))]
public class GuidComponentDrawer : Editor
{
    private GuidComponent guidComp;

    public override void OnInspectorGUI()
    {
        if (guidComp == null)
        {
            guidComp = (GuidComponent)target;
        }
       
        // Draw label
        EditorGUILayout.TextField("Guid:", guidComp.GetGuid().ToString());
    }
}