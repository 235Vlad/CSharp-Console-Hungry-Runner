
using TMPro;
using UnityEngine;


public class food1 : MonoBehaviour, IEatable
{
    public float speed = 50f;
    public Hero hero;
    public TextMeshProUGUI textfly;
    public GameObject textf;
    public void Collect()
    {
        Debug.Log("Еда съедена! food1");
        hero.speeds += 0.50f;
        textfly.text = "+ " + 0.50;
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
