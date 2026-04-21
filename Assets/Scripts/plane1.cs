using UnityEngine;

public class plane1 : MonoBehaviour
{
    public Vector3 panelSize = new Vector3(6, 2, 2);
   
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Hero"))
        {
            Destroy(gameObject);
        }
        if (!other.gameObject.CompareTag("Hero")) return;

        Collider[] hits = Physics.OverlapBox(transform.position, panelSize / 2, transform.rotation);

        foreach (Collider col in hits)
        {
            IEatable eatable = col.GetComponent<IEatable>();
            if (eatable != null)
            {
                eatable.Collect();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, panelSize);
    }

}
