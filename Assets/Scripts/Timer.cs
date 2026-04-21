using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    public TextMeshProUGUI text;
    private float timer;
    private void Update()
    {
        timer += Time.deltaTime;
        int minutes = (int)(timer / 60);
        int seconds = (int)(timer % 60);
        int mlseconds = (int)((timer * 1000) % 1000); 
        text.text = minutes + ":" + seconds + ":" + mlseconds.ToString();
    }
}
