
using UnityEngine;

public class Camerascript : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] public Vector3 offset = new Vector3(-15f, 3f, 0f); 
    [SerializeField] private float smoothSpeed = 5f;
    private void Awake()
    {
        if (!player)
        {
            player = GameObject.FindWithTag("Hero").transform;
        }
    }
    private int ints = 0;

    public int getset
    {
        get { return ints; }
        set { ints = value; }
        
    }

    
    private void LateUpdate() 
    {
        if (player == null) return;
         
        Vector3 targetPosition = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

        transform.LookAt(player); 
    }
}