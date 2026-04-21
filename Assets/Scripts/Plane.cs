using UnityEngine;

public class Plane : MonoBehaviour
{
    public GameObject[] planes;

    private int randomspawn = 0;

    private Vector3 spawnpos = new Vector3(307.73f, 63.5f, 23.2f);
    public GameObject prefab;
    public bool planeactivite = false;
    public Hero hero;
    float index = 0;
    Vector3 planeposition;


    private void Update()
    {
        index = hero.speed;
        if (planeactivite == false && hero.islastobj == true)
        {
            Spawn();
        }
    }
    public void Spawn()
    {
        int count = Mathf.FloorToInt(index);
        for(int i = 0; i < count; i++)
        {
            Vector3 newpos = new Vector3(spawnpos.x + i * 10f, spawnpos.y, spawnpos.z);
            randomspawn = Random.Range(0, planes.Length);
            prefab = planes[randomspawn];
           
            GameObject obj = Instantiate(prefab, newpos, Quaternion.identity);

            obj.tag = "spawn" + (i + 1);

            planeposition = obj.transform.position;
            planeposition.x += 10f;
        }

        GameObject obj2 = Instantiate(planes[Random.Range(0, planes.Length)], planeposition, Quaternion.identity);

        obj2.tag = "r";

        planeactivite = true;
    }


}
