using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameData gameData;
    public TextMeshProUGUI informationPopup;
    public TextMeshProUGUI informationPopup2;
    public GameObject informationPanel;
    public GameObject squareImage;
    public GameObject triangleImage;
    public GameObject circleImage;
    public GameObject starImage;
    private void Start()
    {
        gameData.isDrawing = false;

    }
    public void SquareButton()
    {
        gameData.isDrawing = true;
        EventManager.drawSquare.Invoke();
        
        
    }
    public void TapToSquare()
    {
        informationPanel.SetActive(true);
        squareImage.SetActive(true);
        triangleImage.SetActive(false);
        circleImage.SetActive(false);
        starImage.SetActive(false);
        informationPopup.text = "I am a red square";
        informationPopup2.text = "I have four sides";
    }
    public void TriangleButton()
    {
        gameData.isDrawing = true;
        EventManager.drawTriangle.Invoke();
    }
    public void TapToTriangle()
    {
        informationPanel.SetActive(true);
        triangleImage.SetActive(true);
        squareImage.SetActive(false);
        circleImage.SetActive(false);
        starImage.SetActive(false);
        informationPopup.text = "I am a blue triangle";
        informationPopup2.text = "I have three sides";
    }
    public void CircleButton()
    {
        gameData.isDrawing = true;
        EventManager.drawCircle.Invoke();

    }
    public void TapToCircle()
    {
        informationPanel.SetActive(true);
        circleImage.SetActive(true);
        squareImage.SetActive(false);
        triangleImage.SetActive(false);
        starImage.SetActive(false);
        informationPopup.text = "I am a green circle";
        informationPopup2.text = "I haven't  sides";
    }
    public void StarButton()
    {
        gameData.isDrawing = true;
        EventManager.drawStar.Invoke();

    }
    public void TapToStar()
    {
        informationPanel.SetActive(true);
        circleImage.SetActive(false);
        squareImage.SetActive(false);
        triangleImage.SetActive(false);
        starImage.SetActive(true);
        informationPopup.text = "I am a yellow star";
        informationPopup2.text = "I have a lot of sides";
    }
    public void CencelPopup()
    {

        informationPanel.SetActive(false);
    }
}
