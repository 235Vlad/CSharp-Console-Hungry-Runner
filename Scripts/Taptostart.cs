using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Taptostart : MonoBehaviour
{
    public Hero hero;
    public bool istaptostart = false;
    public GameObject textobj;
    public TextMeshProUGUI text;
    public GameObject image;
    public GameObject overlay;
    public GameObject settings;
    public GameObject scorebutton;

    private void Start()
    {
        textobj = GameObject.FindGameObjectWithTag("texttap");
        text = textobj.GetComponent<TextMeshProUGUI>();
    }


    private void Update()
    {
        if(istaptostart == false)
        {
            hero.GetComponent<Rigidbody>().velocity = Vector3.zero;
            hero.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            hero.isMoving = false;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!IsPointerOverUI(Input.GetTouch(0).fingerId))
            {
                istaptostart = true;
                image.SetActive(false);
                textobj.SetActive(false);
                overlay.SetActive(false);
                scorebutton.SetActive(false);
                settings.SetActive(false);

            }
        }
        
    }
    bool IsPointerOverUI(int fingerId)
    {
        return EventSystem.current.IsPointerOverGameObject(fingerId);
    }
}
