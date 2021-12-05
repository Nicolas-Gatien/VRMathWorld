using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalCube : MonoBehaviour
{
    // VARIABLES
    [Header("Cube Colour")]
    public Material blueMaterial;
    public Material redMaterial;

    public float value = 1;

    // PRIVATE FUNCTIONS
    void Start()
    {
        value = 1;
        SetCubeRed();
    }

    // PUBLIC FUNCTIONS
    public void SetCubeBlue()
    {
        GetComponent<MeshRenderer>().material = blueMaterial;
    }
    public void SetCubeRed()
    {
        GetComponent<MeshRenderer>().material = redMaterial;
    }
    public void SetCubeSize(float _newSize)
    {
        transform.localScale = new Vector3(_newSize, _newSize, _newSize);
    }
}
