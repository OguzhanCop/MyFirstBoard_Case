using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public LineRenderer pencilLine;
    
    public GameObject pencil;
    
    Vector3 lastPos;
    private void OnEnable()
    {
        
        pencilLine.positionCount = 0;
        pencilLine.positionCount = 2;
        pencilLine.SetPosition(0, pencil.transform.position);
        pencilLine.SetPosition(1, pencil.transform.position);
    }
    private void Update()
    {

        PointToMousePos();
    }
    void AddAPoint(Vector3 pointPos)
    {
        pencilLine.positionCount++;
        int positionIndex = pencilLine.positionCount - 1;
        pencilLine.SetPosition(positionIndex, pointPos);
    }

    void PointToMousePos()
    {
        Vector3 pencilPos = pencil.transform.position;
        if (lastPos != pencilPos)
        {
            AddAPoint(pencilPos);
            lastPos = pencilPos;
        }
    }
    void SquarePaintAnimEnd()
    {
        EventManager.squarePaintEnd.Invoke();

    }
    void TrianglePaintAnimEnd()
    {
        EventManager.trianglePaintEnd.Invoke();

    }

    void CirclePaintAnimEnd()
    {
        EventManager.circlePaintEnd.Invoke();

    }
    void StarPaintAnimEnd()
    {
        EventManager.starPaintEnd.Invoke();

    }
}
