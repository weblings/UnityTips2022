using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectDataUser : MonoBehaviour
{
    public ObjectData objectData;

    void Update(){
        if(Keyboard.current.aKey.isPressed && Keyboard.current.wasUpdatedThisFrame){
            print(GetObject().name);
        }
    }

    GameObject GetObject(){
        return GuidManager.ResolveGuid(objectData.guidString);
    }
}
