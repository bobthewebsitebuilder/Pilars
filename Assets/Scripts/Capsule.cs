using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shapes // Inheritance
{
    public override void DisplayInfo() // Polymorphism
    {
        explanationText = "This is a capsule. It has a funny shape.";
        base.DisplayInfo();
    }
}
