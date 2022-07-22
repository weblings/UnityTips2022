using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputGetKeyDown : MonoBehaviour
{
    void Update(){
        /*if(Input.GetKeyDown(KeyCode.A)){
            FunctionToTest();
        }*/

        
        if(Keyboard.current.aKey.isPressed && Keyboard.current.wasUpdatedThisFrame){
            FunctionToTest();
        }
        
    }

    void FunctionToTest(){
        print("oh boy I'm a function");
    }
}
