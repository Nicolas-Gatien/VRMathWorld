using UnityEngine;

public class UniversalCube : MonoBehaviour
{
    // VARIABLES
    [Header("Cube Colour")]
    public Material blueMaterial;
    public Material redMaterial;

    public float value = 1f;

    // PRIVATE FUNCTIONS
    void Start()
    {
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
}
