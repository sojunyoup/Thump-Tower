using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TetrisDragin : MonoBehaviour
{
    public GameObject Tetris;

    [SerializeField]
    private float power = 0.5f;
    [SerializeField]
    private float maxDrag = 1f;
    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]
    private LineRenderer line;
    [SerializeField]
    private SpriteRenderer spriterenderer;
    [SerializeField]
    private GameObject PointPre;
    [SerializeField]
    private GameObject[] Points;

    public float speed;
    public int numberOfpoints;
    Vector3 dragStartPos;
    Touch touch;

    Vector3 clampedForce = Vector3.zero;

    bool isTouch = false;
    float num1;

    Collider2D m_Collider;
    private void Start()
    {
        m_Collider = GetComponent<Collider2D>();
        m_Collider.enabled = false;
        rigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
        Points = new GameObject[numberOfpoints];
        spriterenderer = GetComponent<SpriteRenderer>();
        for (int i = 0; i < numberOfpoints; i++)
        {
            Points[i] = Instantiate(PointPre, transform.position, Quaternion.identity);
        }
        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(false);
        }
    }


    private void Update()
    {

        if(Singleton.Instance.isTetrisMoveUp == true)
        {
            gameObject.transform.position = new Vector3(transform.position.x, Mathf.Lerp(transform.position.y, transform.position.y + 50f, Time.deltaTime * speed), transform.position.z);
            Singleton.Instance.isTetrisMoveUp = false;
        }
        //Touch();
        if(gameObject.GetComponent<TetrisDragin>().enabled == false)
        {
            Singleton.Instance.isAttack = true;
        }
        Click();
        if(Singleton.Instance.CharMove == true)
        {
            transform.position = new Vector3(-4.12f, transform.position.y, transform.position.z);
        }
        else if (Singleton.Instance.CharMove == false)
        {
            transform.position = new Vector3(+4.12f, transform.position.y, transform.position.z);
        }

        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].transform.position = PointPosition(i * 0.1f);
        }

        if (Singleton.Instance.RTurn == true)
        {
            num1 += 90;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, num1);
            Singleton.Instance.RTurn = false;
        }
        if (Singleton.Instance.LTurn == true)
        {
            num1 += 90;
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -num1);
            Singleton.Instance.LTurn = false;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
    }

    Vector2 PointPosition(float t)
    {
        Vector2 currentPointPos;
        currentPointPos = (Vector2)transform.position + ((Vector2)clampedForce * t) + 0.683472f * Physics2D.gravity * 3.0f * (t * t);
        return currentPointPos;
    }

    void DragStart()
    {
        //dragStartPos = Camera.main.ScreenToWorldPoint(touch.position);
        dragStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragStartPos.z = 0f;

        line.positionCount = 1;
        line.SetPosition(0, dragStartPos);

        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(true);
        }

        //Vector3 force = dragStartPos - Camera.main.ScreenToWorldPoint(touch.position);
        Vector3 force = dragStartPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
    }

    void Dragging()
    {
        //Vector3 draggingPos = Camera.main.ScreenToWorldPoint(touch.position);
        Vector3 draggingPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        draggingPos.z = 0f;

        line.positionCount = 2;
        line.SetPosition(1, draggingPos);

        //Vector3 force = dragStartPos - Camera.main.ScreenToWorldPoint(touch.position);
        Vector3 force = dragStartPos - Camera.main.ScreenToWorldPoint(Input.mousePosition);

        clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;

    }

    void DragRelease()
    {
        rigidbody.constraints = 0;
        m_Collider.enabled = true;
        rigidbody.freezeRotation = false;
        line.positionCount = 0;

        //Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(touch.position);
        Vector3 dragReleasePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragReleasePos.z = 0f;

        for (int i = 0; i < Points.Length; i++)
        {
            Points[i].SetActive(false);
        }

        Vector3 force = dragStartPos - dragReleasePos;
        clampedForce = Vector3.ClampMagnitude(force, maxDrag) * power;
        rigidbody.AddForce(clampedForce, ForceMode2D.Impulse);
        Singleton.Instance.isAnimChar = true;
        Invoke("OnTetris", 0.2f);
        Singleton.Instance.isAnimTr = true;
        gameObject.GetComponent<TetrisDragin>().enabled = false;
    }
    void OnTetris()
    {
        Singleton.Instance.isAttack = true;
        //Singleton.Instance.isAttack = false;
    }
    void Click()
    {
        if (EventSystem.current.IsPointerOverGameObject() == false)
        {  //UI이 위가 아니면.
            if (Input.GetMouseButtonDown(0))
            {
                //클릭 처
                DragStart();
            }
            if (Input.GetMouseButton(0))
            {
                //클릭 처리
                Singleton.Instance.isAttack = false;
                Dragging();
            }
            if (Input.GetMouseButtonUp(0))
            {
                //클릭 처리
                DragRelease();
            }
        }
    }

    void Touch()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                DragStart();
            }
            if (touch.phase == TouchPhase.Moved)
            {
                Dragging();
            }
            if (touch.phase == TouchPhase.Ended)
            {
                DragRelease();
            }
        }
    }


}
