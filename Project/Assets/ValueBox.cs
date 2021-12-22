using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValueBox : MonoBehaviour
{
    // VARIABLES
    public float value;

    public Transform checkPos;
    public float checkRadius;
    public Vector3 checkArea; 

    public Collider[] overlappedCubes;

    public TextMeshProUGUI valueText;
    
    // PRIVATE FUNCTIONS
    void Start()
    {
        checkArea = new Vector3(checkRadius, checkRadius, checkRadius);
    }

    void Update()
    {
        overlappedCubes = Physics.OverlapBox(checkPos.position, checkArea / 2);
        for (int i = 0; i < overlappedCubes.Length; i++)
        {
            if (checkIfObjectIsUniversalCube(overlappedCubes[i].gameObject))
            {
                UniversalCube cube = overlappedCubes[i].GetComponent<UniversalCube>();
                value++;
                cube.SetCubeBlue();
            }
        }

        if(valueText != null)
        {
            valueText.text = "m = " + value;
        }
    }
    private void LateUpdate()
    {
        value = 0;
    }
    bool checkIfObjectIsUniversalCube(GameObject subject)
    {
        if (subject.GetComponent<UniversalCube>())
        {
            return true;
        }else
        {
            return false;
        }
    }
    
    // INSPECTOR FUNCTIONS
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(checkPos.position, checkArea);
    }
}
