using UnityEngine;

public class onelinie : MonoBehaviour
{
    private bool findobject = false; 
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hero"))
        {
            findobject = true;
        }
    }

    private void Update()
    {
        if(findobject == true)
        {
            GameObject nearest = FindClosestObject();
            if (nearest != null)
            {
                Destroy(nearest);
            }
            findobject = false;
        }
    }

    public GameObject FindClosestObject()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("twolinie");
        GameObject closest = null;
        float mindistance = Mathf.Infinity;
        Vector3 currentobj = transform.position;

        foreach(GameObject target in targets)
        {
            float distance = (target.transform.position - currentobj).sqrMagnitude;
            if(distance < mindistance)
            {
                closest = target;
                mindistance = distance;
            }
        }
        return closest;
    } 
}
