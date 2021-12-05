using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grapher : MonoBehaviour
{
    // VARIABLES
    public GameObject point;
    public LineRenderer line;

    public ValueBox mValue;
    public ValueBox bValue;

    // PRIVATE FUNCTIONS
    void Update()
    {
            drawLinearRelation(mValue.value, bValue.value);
    }

    // PUBLIC FUNCTIONS
    public void drawLinearRelation(float m, float b)
    {
        GameObject[] allPoints = GameObject.FindGameObjectsWithTag("Point");
        for (int i = 0; i < allPoints.Length; i++)
        {
            Destroy(allPoints[i]);
        }

        float x = -5;
        float y = (m * x) + b;

        Vector3 pointLocation = new Vector3(x, y, 0) + transform.position;
        List<Vector3> drawnPoints = new List<Vector3>();

        GameObject curPoint = Instantiate(point, pointLocation, Quaternion.identity);
        drawnPoints.Add(curPoint.transform.position);

        while (x < 5)
        {
            x++;
            y = (m * x) + b;

            pointLocation = new Vector3(x, y, 0) + transform.position;

            curPoint = Instantiate(point, pointLocation, Quaternion.identity);
            drawnPoints.Add(curPoint.transform.position);
        }

        line.positionCount = drawnPoints.Count;
        line.SetPositions(drawnPoints.ToArray());
    }
}
