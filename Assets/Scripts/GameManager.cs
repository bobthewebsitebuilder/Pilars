using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text shapeInfoText;
    public Shapes selectedShape;

    public void UpdateShapeInfo() // Encapsulation and Abstraction
    {
        if (selectedShape != null)
        {
            selectedShape.DisplayInfo();
        }
    }

    private void Update()
    {
        if (selectedShape != null)
        {
            selectedShape.Update();
        }
    }

    public void SelectShape(Shapes shape) // Encapsulation and Abstraction
    {
        selectedShape = shape;
        UpdateShapeInfo();
    }

    public void ChangeScene() // Abstraction
    {
        SceneManager.LoadScene(1);
    }

    public void ReturnToTitle() // Abstraction
    {
        SceneManager.LoadScene(0);
    }

}
