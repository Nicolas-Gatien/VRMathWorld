using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalCube : MonoBehaviour
{
    // VARIABLES
    [Header("Cube Colour")]
    public const string RED = "red";
    public const string BLUE = "blue";

    public string colour;

    public Material blueMaterial;
    public Material redMaterial;

    // PRIVATE FUNCTIONS
    void Start()
    {
        colour = BLUE;
    }

    void Update()
    {
        UpdateCubeColour();
    }

    void UpdateCubeColour()
    {
        if (colour == BLUE) { GetComponent<MeshRenderer>().materials[0] = blueMaterial; }
        else if (colour == RED) { GetComponent<MeshRenderer>().materials[0] = redMaterial; }
    }

    // PUBLIC FUNCTIONS
    public void InvertCubeColour()
    {
        if(colour == BLUE) { 
            colour = RED; 
        } else if(colour== RED) { 
            colour = BLUE; 
        } else { 
            return; 
        }
    }
    public void SetCubeColour(string _newColour)
    {
        if(_newColour != RED | _newColour != BLUE) {
            Debug.LogError(_newColour + " != to 'red' or 'blue'");
        }else {
            colour = _newColour;
        }
    }
    public void SetCubeSize(float _newSize)
    {
        transform.localScale = new Vector3(_newSize, _newSize, _newSize);
    }
}
