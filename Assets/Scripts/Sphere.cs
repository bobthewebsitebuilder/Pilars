using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes // Inheritance
{
    public override void DisplayInfo() // Polymorphism
    {
        explanationText = "This is a sphere. It is smoothly round.";
        base.DisplayInfo();
    }
}

