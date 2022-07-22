using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SubMenuInputWindow  : EditorWindow
{
    public LiftConversations conversations;
    public int conversationsIndex = 0;

    [MenuItem("Window/LiftTools/LiftConversations Input")]
    static void Init(){
        SubMenuInputWindow window = (SubMenuInputWindow)EditorWindow.GetWindow(typeof(SubMenuInputWindow));
        window.Show();
    }

    public void OnGUI(){
        conversations = EditorGUILayout.ObjectField("LiftConversations",conversations,typeof(LiftConversations)) as LiftConversations;
        if(conversations != null) conversationsIndex = EditorGUILayout.Popup(conversationsIndex, conversations.conversationsList);
    }

}
