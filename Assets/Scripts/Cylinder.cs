using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shapes // Inheritance
{
    public override void DisplayInfo()  // Polymorphism
    {
        explanationText = "This is a cylinder. It has a very weird shape.";
        base.DisplayInfo();
    }
}

