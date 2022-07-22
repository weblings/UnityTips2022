using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
using UnityEditorInternal; 
#endif

#if UNITY_EDITOR
[CustomEditor(typeof(AnimationTruth))]
public class AnimationTruthEditor : Editor
{
    AnimationTruth animationTruth;
    SerializedProperty animationObjects;      
    ReorderableList animationObjectsList;
    //GUIContent[] animationObjectsListGUIContent; 

    private void OnEnable()
    {
        animationTruth = (AnimationTruth) target;
        animationObjects = serializedObject.FindProperty("animationObjects");

        animationObjectsList = new ReorderableList(serializedObject, animationObjects, true, true, true, true);
        animationObjectsList.drawElementCallback = DrawListItems;
        animationObjectsList.drawHeaderCallback = rect => EditorGUI.LabelField(rect, animationObjects.displayName);
        animationObjectsList.elementHeightCallback += index => (EditorGUIUtility.singleLineHeight * 2) + 10;
    }


    public override void OnInspectorGUI(){
        animationTruth.dataTypes = (AnimationDataTypes) EditorGUILayout.ObjectField("DataTypes", (AnimationDataTypes) animationTruth.dataTypes, typeof(AnimationDataTypes), true);

        serializedObject.Update();
        animationObjectsList.DoLayoutList();
        serializedObject.ApplyModifiedProperties();
    }

    void DrawListItems(Rect rect, int index, bool isActive, bool isFocused){
        SerializedProperty element = animationObjectsList.serializedProperty.GetArrayElementAtIndex(index); //The element in the list
        float popUpHeight = EditorGUI.GetPropertyHeight(element);
        element.FindPropertyRelative("dataTypesIndex").intValue = EditorGUI.Popup(new Rect(rect.x, rect.y, rect.width, popUpHeight), element.FindPropertyRelative("dataTypesIndex").intValue, animationTruth.dataTypes.dataTypes); 
        element.FindPropertyRelative("functions").objectReferenceValue = (AnimationFunctions) EditorGUI.ObjectField(new Rect(rect.x, rect.y + popUpHeight, rect.width, popUpHeight), element.FindPropertyRelative("functions").objectReferenceValue, typeof(AnimationFunctions));      
    }

}
#endif
