

using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] spawnobjects;
    private float step = 30f; 
    public GameObject finishLine;
    public Transform Hero;
    private int randomindexspawn = 0;
    private Vector3 spawnpos = new Vector3(23.89f, 67.13f, 16.08f);
    private Vector3 spawnposl = new Vector3(23.89f, 67.13f, 30.97f);
    public GameObject prefab;
    public GameObject purpleplane;
    public GameObject redplane;
    private bool spawn = true;
    private int spawnposibility = 0;

    public GameObject lastobjl;
    public GameObject lastobjr;
    public bool islastl = false;
    public bool islastr = false;





    private void Start()
    {
    }

    private void Update()
    {
        
        
        if(spawn == true)
        {
            for (spawnposibility = 0; spawnposibility < 10; spawnposibility++)
            {
                randomindexspawn = Random.Range(0, spawnobjects.Length);
                prefab = spawnobjects[randomindexspawn];

                lastobjl = Instantiate(prefab, spawnpos, Quaternion.identity);
                
                GameObject purpleplaneobj = Instantiate(purpleplane, spawnpos, Quaternion.identity);
                purpleplaneobj.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                purpleplaneobj.tag = "plane";
                spawnpos.x += step;

                if (spawnposibility == 9)
                {
                    islastl = true;
                    lastobjl.tag = "lastl";
                    purpleplaneobj.tag = "planel";
                    
                }

                

            }
           
            for (spawnposibility = 0; spawnposibility < 10; spawnposibility++)
            {
                randomindexspawn = Random.Range(0, spawnobjects.Length);
                prefab = spawnobjects[randomindexspawn];

                lastobjr = Instantiate(prefab, spawnposl, Quaternion.identity);
                GameObject redplaneobj = Instantiate(redplane, spawnposl, Quaternion.identity);
                redplaneobj.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
                redplaneobj.tag = "plane";

                spawnposl.x += step;

                if (spawnposibility == 9)
                {
                    islastr = true;
                    lastobjr.tag = "lastr";
                    redplaneobj.tag = "planer";
                }

                
            }

            
            

        }
        if(spawnposibility <= 10)
        {
            spawn = false;
        }
    }

}
