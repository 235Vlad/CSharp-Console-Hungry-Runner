using TMPro;
using UnityEngine;

public class food7 : MonoBehaviour, IEatable
{
    public float speed = 50f;
    public Hero hero;
    private bool courutinefoods = false;
    private bool courutinefoodsdestroy = false;
    public TextMeshProUGUI textfly;
    public GameObject textf;
    public void Collect()
    {
        Debug.Log("Еда съедена! food7");
        hero.isfood7 = true;
        hero.isfood77 = false;
        textfly.text = "+ " + 1.5 + " for only 6 seconds";
        hero.StartCoroutine(hero.textfly1());
        colorrandom();
        Destroy(gameObject);


    }
    private void Start()
    {
        GameObject gameObjectfind = GameObject.FindWithTag("Hero");
        hero = gameObjectfind.GetComponent<Hero>();
        textf = GameObject.FindGameObjectWithTag("textf");
        textfly = textf.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * speed, 0);
    }
    public void colorrandom()
    {
        textfly.color = UnityEngine.Random.ColorHSV(0f, 1f,
  0.7f, 1f,
  0.8f, 1f);
    }
}
