using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hero : MonoBehaviour
{
    private Vector3 targetposition;
    public bool isMoving = false;
    public Rigidbody rb;
    [SerializeField] public float speed = 5f;
    public Animator animator;
    public GameObject food4;
    public bool isfood4 = false;
    public bool isfood44 = false;
    public bool isfood7 = false;
    public bool isfood77 = false;
    public bool isfood19 = false;
    public bool isfood1919 = false;
    private bool ishit = false;
    public TextMeshProUGUI text;
    public TextMeshProUGUI counter;
    public GameObject textcounter;
    public GameObject textobj;
    public bool islastobj = false;
    private bool iscounteractiv = false;
    private bool isprefscan = false;
    public float highspeedobj = 0f;
    public TextMeshProUGUI textfly;
    public GameObject textf;
    public food9 food9;
    public Taptostart taptostart;
    public float sideSpeed = 5f;
    public float maxX = 3f;


    private void Start()
    {
        textobj = GameObject.FindGameObjectWithTag("text");
        textf = GameObject.FindGameObjectWithTag("textf");
        textfly = textf.GetComponent<TextMeshProUGUI>();
        text = textobj.GetComponent<TextMeshProUGUI>();
        rb = GetComponent<Rigidbody>();
        



    }
    
    public IEnumerator textfly1()
    {
        yield return new WaitForSeconds(1f);
        textfly.text = " "; 
    }
    private void Update()
    {
        highspeedobj = PlayerPrefs.GetFloat("Highspeed", 0);

        text.text = speed.ToString("F2");
           if(Input.touchCount > 0 && taptostart.istaptostart == true)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)) {
                    if (hit.collider.CompareTag("food"))
                    {
                        Vector3 foodPos = hit.collider.transform.position;

                        targetposition = new Vector3(
                            foodPos.x,
                            rb.position.y,
                            foodPos.z
                        );

                        isMoving = true;
                    }
                        if (hit.collider.CompareTag("lastl"))
                    {
                        targetposition = new Vector3(
                            hit.point.x,
                            transform.position.y,
                            hit.point.z
                        );
                        isMoving = true;

                    }
                    if (hit.collider.CompareTag("lastr"))
                    {
                        targetposition = new Vector3(
                            hit.point.x,
                            transform.position.y,
                            hit.point.z
                        );
                        isMoving = true;

                    }
                    else
                    {
                        targetposition = hit.point;
                        isMoving = true;
                    }
                    if (hit.collider.CompareTag("plane"))
                    {
                        targetposition = new Vector3(
                            hit.point.x,
                            transform.position.y,
                            hit.point.z
                        );
                        isMoving = true;
                    }
                }
            }

           
        }


        if (isfood4 == true && isfood44 == false)
        {
            StartCoroutine(courotinefood4());
            isfood44 = true;
        }

        if(isfood7 == true && isfood77 == false)
        {
            StartCoroutine(courotinefood7());
            isfood77 = true;
        }

        if (isfood19 == true && isfood1919 == false)
        {
            StartCoroutine(courotinefood19());
            isfood1919 = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("lastl"))
        {
            islastobj = true;
        }
        if (collision.gameObject.CompareTag("planel"))
        {
            islastobj = true;
        }
        if (collision.gameObject.CompareTag("lastr"))
        {
            islastobj = true;
        }
        if (collision.gameObject.CompareTag("planer"))
        {
            islastobj = true;
        }

        if (collision.gameObject.CompareTag("spawn1"))
        {
            counter.text = "100";
            textcounter.SetActive(true);
            iscounteractiv = true;
            colorrandom();
            UpdateHighSpeed();
        }
        if (collision.gameObject.CompareTag("spawn2"))
        {
            counter.text = "200";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn3"))
        {
            counter.text = "300";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn4"))
        {
            counter.text = "400";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn5"))
        {
            counter.text = "500";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn6"))
        {
            counter.text = "600";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn7"))
        {
            counter.text = "700";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn8"))
        {
            counter.text = "800";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn9"))
        {
            counter.text = "900";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn10"))
        {
            counter.text = "1000";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn11"))
        {
            counter.text = "1100";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn12"))
        {
            counter.text = "1200";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn13"))
        {
            counter.text = "1300";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn14"))
        {
            counter.text = "1400";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn15"))
        {
            counter.text = "1500";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn16"))
        {
            counter.text = "1600";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn17"))
        {
            counter.text = "1700";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn18"))
        {
            counter.text = "1800";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn19"))
        {
            counter.text = "1900";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn20"))
        {
            counter.text = "2000";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn21"))
        {
            counter.text = "2100";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn22"))
        {
            counter.text = "2200";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn23"))
        {
            counter.text = "2300";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn24"))
        {
            counter.text = "2400";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn25"))
        {
            counter.text = "2500";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn26"))
        {
            counter.text = "2600";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn27"))
        {
            counter.text = "2700";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn28"))
        {
            counter.text = "2800";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn29"))
        {
            counter.text = "2900";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("spawn30"))
        {
            counter.text = "3000";
            colorrandom();
        }
        if (collision.gameObject.CompareTag("r"))
        {
            counter.text = "continue";
            colorrandom();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
   
    public void colorrandom()
    {
        counter.color = Random.ColorHSV(0f, 1f,
  0.7f, 1f,
  0.8f, 1f);
    }
    public float speeds
    {
        get { return speed; }
        set { speed = value; }
    }
    private States State
    {
        get { return (States)animator.GetInteger("State"); }
        set { animator.SetInteger("State", (int)value); }
    }

    public IEnumerator courotinefood4()
    {
        yield return new WaitForSeconds(0f);
        speed += 1f;
        yield return new WaitForSeconds(3f);
        speed -= 1f;
    }

    public IEnumerator courotinefood7()
    {
        yield return new WaitForSeconds(0f);
        speed += 1.5f;
        yield return new WaitForSeconds(6f);
        speed -= 1.5f;
    }

    public IEnumerator courotinefood19()
    {
        yield return new WaitForSeconds(0f);
        speed += 0.70f;
        yield return new WaitForSeconds(12f);
        speed -= 0.70f;
    }

    public void UpdateHighSpeed()
    {
        if(!PlayerPrefs.HasKey("Highspeed"))
        {
            PlayerPrefs.SetFloat("Highspeed", speed);
            PlayerPrefs.Save();
        }
        else
        {
            float currenthigh = PlayerPrefs.GetFloat("Highspeed", 0);
            if(speed > currenthigh)
            {
                PlayerPrefs.SetFloat("Highspeed", speed);
                PlayerPrefs.Save();
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 direction = (targetposition - transform.position);
        direction.y = 0f;              
        direction = direction.normalized;

        if (direction != Vector3.zero)
        {
            if (direction.x < 0f)
            {
                direction = Vector3.zero;
                isMoving = false;
            }

            Quaternion targetRotation = Quaternion.LookRotation(direction);
            rb.MoveRotation(targetRotation);
        }

        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
        State = States.run;

        if (Vector3.Distance(transform.position, targetposition) < 0.1f)
        {
            isMoving = false;
        }
        else
        {
            State = States.idle;
        }
    }

}



public enum States
{
    idle,
    run
}