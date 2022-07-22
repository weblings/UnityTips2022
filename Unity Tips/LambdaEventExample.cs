using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Example script for showcasing the Lambda Function and Context Menu examples
/// </summary>
public class LambdaEventExample : MonoBehaviour
{
    public enum ColorOptions {White,Green,Red,Blue}
    public ColorOptions colorOption;

    public Image image;
    public Button button;

    void Start(){
        button.onClick.AddListener(() => ChangeColor(colorOption));
    }

    public void VoidFunction(){
        print("I work");
    }

    [ContextMenu("Example")]
    void ChangeColorExample(){
        ChangeColor(colorOption);
    }

    public void ChangeColor(ColorOptions colorOption){
        switch(colorOption){
            case ColorOptions.White:
                image.color = Color.white;
                break;
            case ColorOptions.Green:
                image.color = Color.green;
                break;
            case ColorOptions.Red:
                image.color = Color.red;
                break;
            case ColorOptions.Blue:
                image.color = Color.blue;
                break;
        }
    }
}
