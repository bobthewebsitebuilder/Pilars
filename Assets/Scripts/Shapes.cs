using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shapes : MonoBehaviour
{
    // Abstraction
    protected string explanationText;
    protected float rotationSpeed = 80.0f;
    public Text shapeInfoText;


    public virtual void Update()
    {
        RotateShape();
    }

    protected virtual void RotateShape() // Abstraction and Polymorphism
    {
        transform.Rotate(transform.right * rotationSpeed * Time.deltaTime);
    }

    public virtual void DisplayInfo() // Abstraction and Polymorphism
    {
        string displayedText = string.IsNullOrEmpty(explanationText) ? "" : explanationText;

        if (shapeInfoText != null)
        {
            shapeInfoText.text = displayedText;
        }
    }

}



