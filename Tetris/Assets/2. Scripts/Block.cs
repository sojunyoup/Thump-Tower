using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Block : MonoBehaviour
{
    //블럭 랜덤 돌리기
    public int curTetris;
    public GameObject [] m_goPrefab = null;
    public Transform m_tfBlock = null;
    GameObject t_Block;
    public float cooltime;
    public float curtime;

    Camera m_cam = null;

    public GameObject Player;

    //ui클릭 방지
    public bool isClick;

    //손
    public GameObject throwPos = null;

    // Start is called before the first frame update
    void Start()
    {
        Singleton.Instance.isAttack = true;
        curTetris = Random.Range(1, 22);
        Singleton.Instance.Tetris = Random.Range(1, 22);

        m_cam = Camera.main;
        //m_cam = Player.transform.position;
    }
    void TryFire()
    {
        if (Singleton.Instance.isAttack == true)
        {
            if (curTetris == 1 || curTetris == 2)
            {
                t_Block = Instantiate(m_goPrefab[0], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f,0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 3 || curTetris == 4)
            {
                t_Block = Instantiate(m_goPrefab[1], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 5 || curTetris == 6)
            {
                t_Block = Instantiate(m_goPrefab[2], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 7 || curTetris == 8)
            {
                t_Block = Instantiate(m_goPrefab[3], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 9 || curTetris == 10)
            {
                t_Block = Instantiate(m_goPrefab[4], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 11 || curTetris == 12)
            {
                t_Block = Instantiate(m_goPrefab[5], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 13 || curTetris == 14)
            {
                t_Block = Instantiate(m_goPrefab[6], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 15)
            {
                t_Block = Instantiate(m_goPrefab[7], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 16)
            {
                t_Block = Instantiate(m_goPrefab[8], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 17)
            {
                t_Block = Instantiate(m_goPrefab[9], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 18)
            {
                t_Block = Instantiate(m_goPrefab[10], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 19)
            {
                t_Block = Instantiate(m_goPrefab[11], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 20)
            {
                t_Block = Instantiate(m_goPrefab[12], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
            else if (curTetris == 21)
            {
                t_Block = Instantiate(m_goPrefab[13], new Vector3(m_tfBlock.position.x, m_tfBlock.position.y + 1.0f, 0), Quaternion.Euler(0, 0, 0));
                Singleton.Instance.Tetris = Random.Range(1, 22);
                curTetris = Singleton.Instance.Tetris;
                Singleton.Instance.isAttack = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject())
            {
                isClick = true;
            }
            else
            {
                isClick = false;
                curtime = 0;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            curtime = 0;
        }
        if (isClick == false)
        {
            if (curtime >= cooltime)
            {
                if (Singleton.Instance.count == true)
                {
                    TryFire();
                    curtime = 0;
                    Singleton.Instance.count = false;
                }
            }
            curtime += Time.deltaTime;   //클릭 처리
        }
        
    }
}
