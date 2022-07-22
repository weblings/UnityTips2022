using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AnimationTruth", menuName = "ScriptableObjects/AnimationExample/Source of Truth", order = 1)]
public class AnimationTruth : ScriptableObject
{
    [System.Serializable]
    public class AnimationObject{
        public int dataTypesIndex;
        public AnimationFunctions functions;
    }

    public AnimationDataTypes dataTypes;

    public AnimationObject[] animationObjects;
}
