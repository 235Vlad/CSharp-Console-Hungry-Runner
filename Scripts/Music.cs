using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Music : MonoBehaviour, IPointerClickHandler
{
    public AudioClip audioclip;
    public AudioSource audiosource;
    private bool ismusic = false;
    private bool isplaying = true;
    public Image buttonImage;

    public void OnPointerClick(PointerEventData eventData)
    {
        ismusic = !ismusic;

        if (ismusic)
        {
            isplaying = false;
            DarkenButton();
        }
        else
        {
            isplaying = true;
            ResetButtonColor();
        }
    }
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
        audiosource.clip = audioclip;
    }

    private void Update()
    {
        if (!audiosource.isPlaying && isplaying == true)
        {
            audiosource.Play();
        }
        if(isplaying == false)
        {
            audiosource.Stop();
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
