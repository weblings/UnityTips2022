using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConverasationsSOTest", menuName = "ScriptableObjects/Lift/ConversationsSOTest", order = 1)]
public class ConversationsSOTest : ScriptableObject
{
    public LiftConversations conversations;
    public int conversationsIndex;
}
