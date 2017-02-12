using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

    public Material redMaterial;
    public Material blueMaterial;
    public Material greenMaterial;
    public Material yellowMaterial;
    public GameManager.Colors colour;

    GameManager.Colors ChangeColor(Renderer rend, int colorID)
    {
        switch (colorID)
        {
            case 0:
                colour = GameManager.Colors.RED;
                rend.material = redMaterial;
                break;
            case 1:
                colour = GameManager.Colors.GREEN;
                rend.material = greenMaterial;
                break;
            case 2:
                colour = GameManager.Colors.BLUE;
                rend.material = blueMaterial;
                break;
            case 3:
                colour = GameManager.Colors.YELLOW;
                rend.material = yellowMaterial;
                break;
        }
        return colour;
    }
}
