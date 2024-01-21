using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shapes // Inheritance
{
    public override void DisplayInfo() // Polymorphism
    {
        explanationText = "This is a cube. It looks like a closed box.";
        base.DisplayInfo(); 
    }
}
