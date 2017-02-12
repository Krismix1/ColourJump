using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour {

    public Material redMaterial;
    public Material blueMaterial;
    public Material greenMaterial;
    public Material yellowMaterial;
    public GameManager.Colours colour;

    private void Start()
    {
        int colourID = Random.Range(0, 4);
        Renderer rend = GetComponent<Renderer>();
        ChangeColor(rend, colourID);
    }

    public GameManager.Colours ChangeColor(Renderer rend, int colourID)
    {
        switch (colourID)
        {
            case 0:
                colour = GameManager.Colours.RED;
                rend.material = redMaterial;
                break;
            case 1:
                colour = GameManager.Colours.GREEN;
                rend.material = greenMaterial;
                break;
            case 2:
                colour = GameManager.Colours.BLUE;
                rend.material = blueMaterial;
                break;
            case 3:
                colour = GameManager.Colours.YELLOW;
                rend.material = yellowMaterial;
                break;
        }
        return colour;
    }
}
