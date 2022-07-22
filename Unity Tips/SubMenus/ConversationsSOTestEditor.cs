using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

#if UNITY_EDITOR
[CustomEditor(typeof(ConversationsSOTest))]
public class ConversationsSOTestEditor : Editor
{
    private ConversationsSOTest test;

    private void OnEnable()
    {
        test = (ConversationsSOTest) target;
    }


    public override void OnInspectorGUI()
    {
        test.conversations = (LiftConversations) EditorGUILayout.ObjectField("LiftConversations", (LiftConversations) test.conversations, typeof(LiftConversations), true);
        if(test.conversations != null) test.conversationsIndex = EditorGUILayout.Popup(test.conversationsIndex, test.conversations.conversationsList);
    }

}
#endif
