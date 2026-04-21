using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Scorebutton : MonoBehaviour, IPointerClickHandler
{
    public Hero hero;
    public TextMeshProUGUI score;
    public Image buttonImage; 
    private bool isTextVisible = false;
    public void OnPointerClick(PointerEventData eventData)
    {
        score.text = "Score " + hero.highspeedobj.ToString();
        colorrandom();
        hero.isMoving = false;
        hero.GetComponent<Rigidbody>().velocity = Vector3.zero;
        hero.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        isTextVisible = !isTextVisible;
        score.gameObject.SetActive(isTextVisible);


        if (isTextVisible)
        {
            score.text = "Score: " + hero.highspeedobj.ToString();
            DarkenButton();
        }
        else
        {
            ResetButtonColor();
        }
    }
    private void DarkenButton()
    {
        if (buttonImage != null)
        {
            buttonImage.color = new Color(0.5f, 0.5f, 0.5f); 
        }
    }
    private void ResetButtonColor()
    {
        if (buttonImage != null)
        {
            buttonImage.color = Color.white; 
        }
    }


    public void colorrandom()
    {
        score.color = Random.ColorHSV(0f, 1f,
  0.7f, 1f,
  0.8f, 1f);
    }
}
