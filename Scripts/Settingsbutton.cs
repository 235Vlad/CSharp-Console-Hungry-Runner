using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Settingsbutton : MonoBehaviour, IPointerClickHandler 
{
    private bool issettings = false;
    public Hero hero;
    public GameObject music;
    public GameObject audio;
    public Image buttonImage;
    public void OnPointerClick(PointerEventData eventData)
    {
        issettings = !issettings;
        music.GetComponent<Image>().enabled = issettings;
        hero.isMoving = false;
        audio.SetActive(issettings);

        if(issettings)
        {
            Time.timeScale = 0f;
            DarkenButton();
        }
        else
        {
            Time.timeScale = 1f;
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
}
