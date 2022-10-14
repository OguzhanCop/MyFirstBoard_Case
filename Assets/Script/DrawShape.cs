using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawShape : MonoBehaviour
{

    public LineRenderer pencilLine;
    public GameObject pencil;
    public GameObject squarePaintPencil;
    public GameObject trianglePaintPencil;
    public GameObject circlePaintPencil;
    public GameObject starPaintPencil;
    public GameObject squareImage;
    public GameObject triangleImage;
    public GameObject circleImage;
    public GameObject starImage;
    public Animator paintSquareAnimator;
    public Animator paintTriangleAnimator;
    public Animator paintCircleAnimator;
    public Animator paintStarAnimator;
    public GameData gameData;

    

    Vector3 lastPos;
    private void OnEnable()
    {
        EventManager.drawSquare += DrawSquare;
        EventManager.squarePaintEnd += SquarePaintEnd;
        EventManager.drawTriangle += DrawTriangle;
        EventManager.trianglePaintEnd += TrianglePaintEnd;
        EventManager.drawCircle += DrawCircle;
        EventManager.circlePaintEnd += CirclePaintEnd;
        EventManager.drawStar += DrawStar;
        EventManager.starPaintEnd += StarPaintEnd;

    }
    private void OnDisable()
    {

        EventManager.drawSquare -= DrawSquare;
        EventManager.squarePaintEnd -= SquarePaintEnd;
        EventManager.drawTriangle -= DrawTriangle;
        EventManager.trianglePaintEnd -= TrianglePaintEnd;
        EventManager.drawCircle -= DrawCircle;
        EventManager.circlePaintEnd -= CirclePaintEnd;
        EventManager.drawStar -= DrawStar;
        EventManager.starPaintEnd -= StarPaintEnd;
    }
    private void Update()
    {
        if (gameData.isDrawing)
        {
            PointToMousePos();
        }

    }

    void DrawSquare()
    {
        squareImage.SetActive(false);
        triangleImage.SetActive(false);
        circleImage.SetActive(false);
        starImage.SetActive(false);
        pencil.transform.position = new Vector3(-0.08f, 0.15f, 0);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        pencilLine.positionCount = 0;
        pencilLine.positionCount = 2;
        pencilLine.SetPosition(0, pencil.transform.position);
        pencilLine.SetPosition(1, pencil.transform.position);
        pencil.GetComponent<Animator>().SetTrigger("Square");

    }
    public void SquarePaintingAnim()
    {
        squarePaintPencil.SetActive(true);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        paintSquareAnimator.SetTrigger("Start");
    }
    public void SquarePaintEnd()
    {
        squarePaintPencil.SetActive(false);
        gameData.isDrawing = false;
        squareImage.SetActive(true);

    }
    void DrawTriangle()
    {

        squareImage.SetActive(false);
        triangleImage.SetActive(false);
        circleImage.SetActive(false);
        starImage.SetActive(false);
        pencil.transform.position = new Vector3(0, 0.15f, 0);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        pencilLine.positionCount = 0;
        pencilLine.positionCount = 2;
        pencilLine.SetPosition(0, pencil.transform.position);
        pencilLine.SetPosition(1, pencil.transform.position);
        pencil.GetComponent<Animator>().SetTrigger("Triangle");


    }
    public void TrianglePaintingAnim()
    {
        trianglePaintPencil.SetActive(true);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        
        paintTriangleAnimator.SetTrigger("Start");
    }
    public void TrianglePaintEnd()
    {
        trianglePaintPencil.SetActive(false);
        gameData.isDrawing = false;
        triangleImage.SetActive(true);

    }
    void DrawCircle()
    {

        squareImage.SetActive(false);
        triangleImage.SetActive(false);
        circleImage.SetActive(false);
        starImage.SetActive(false);
        pencil.transform.position = new Vector3(0, 0.15f, 0);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        pencilLine.positionCount = 0;
        pencilLine.positionCount = 2;
        pencilLine.SetPosition(0, pencil.transform.position);
        pencilLine.SetPosition(1, pencil.transform.position);
        pencil.GetComponent<Animator>().SetTrigger("Circle");


    }
    public void CirclePaintingAnim()
    {
        circlePaintPencil.SetActive(true);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(false);

        paintCircleAnimator.SetTrigger("Start");
    }
    public void CirclePaintEnd()
    {
        circlePaintPencil.SetActive(false);
        gameData.isDrawing = false;
        circleImage.SetActive(true);

    }
    void DrawStar()
    {
        squareImage.SetActive(false);
        triangleImage.SetActive(false);
        circleImage.SetActive(false);
        starImage.SetActive(false);

        pencil.transform.position = new Vector3(0, 0.15f, 0);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        pencilLine.positionCount = 0;
        pencilLine.positionCount = 2;
        pencilLine.SetPosition(0, pencil.transform.position);
        pencilLine.SetPosition(1, pencil.transform.position);
        pencil.GetComponent<Animator>().SetTrigger("Star");


    }
    public void StarPaintingAnim()
    {
        starPaintPencil.SetActive(true);
        pencil.gameObject.transform.GetChild(0).gameObject.SetActive(false);

        paintStarAnimator.SetTrigger("Start");
    }
    public void StarPaintEnd()
    {
       starPaintPencil.SetActive(false);
        gameData.isDrawing = false;
        starImage.SetActive(true);

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
    
}
