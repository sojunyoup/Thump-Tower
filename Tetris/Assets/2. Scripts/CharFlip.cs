using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class CharFlip : MonoBehaviour
{
    private SpriteRenderer mySprite;
    Animator animator;
    public GameObject Player;
    public Text Score;
    public GameObject[] LeftRight;
    public GameObject cemara;
    void Start()
    {
        Score.text = " " + Singleton.Instance.Score + " ";
        mySprite = gameObject.GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        animator.SetBool("isIdel", true);
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = " " + Singleton.Instance.Score+ " ";
        if (Singleton.Instance.CharMove == true)
        {
            Player.transform.position = LeftRight[0].transform.position;
            cemara.transform.position = new Vector3(-1.4f, cemara.transform.position.y, -10);
            Singleton.Instance.CanAttack = false;
        }
        else if (Singleton.Instance.CharMove == false)
        {
            Player.transform.position = LeftRight[1].transform.position;
            cemara.transform.position = new Vector3(1.4f, cemara.transform.position.y, -10);
            Singleton.Instance.CanAttack = false;
        }
        if (Singleton.Instance.CharMove == true)
        {
            mySprite.flipX = true;
        }
        else if (Singleton.Instance.CharMove == false)
        {
            mySprite.flipX = false;
        }
        //if (Input.GetMouseButtonUp(0))
        //{
        //    if (EventSystem.current.IsPointerOverGameObject())
        //    {
        //        animator.SetBool("isPup", false);
        //        animator.SetBool("isIdel", false);
        //    }
        //    else
        //    {
        //        Singleton.Instance.isAnimChar = false;
        //        animator.SetBool("isPup", true);
        //        animator.SetBool("isIdel", false);

        //    }
        //}
        ////if (Singleton.Instance.isAnimTr == true)
        ////{
        ////    animator.SetBool("isPup", true);
        ////    animator.SetBool("isIdel", false);
        ////    Singleton.Instance.isAnimTr = false;
        ////}
        //if (Singleton.Instance.isAnimChar == true)
        //{
        //    if (EventSystem.current.IsPointerOverGameObject())
        //    {
        //        animator.SetBool("isPup", false);
        //        animator.SetBool("isIdel", false);
        //    }
        //    else
        //    {
        //        animator.SetBool("isPup", false);
        //        animator.SetBool("isIdel", true);
        //    }
        //}
        if (Input.GetMouseButtonUp(0) || Singleton.Instance.isAnimTr == true)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                animator.SetBool("isPup", true);
                animator.SetBool("isBack", false);
                animator.SetBool("isIdel", false);
                Singleton.Instance.isAnimTr = false;
            }
        }
        else
        {
            animator.SetBool("isPup", false);
            animator.SetBool("isBack", true);
            animator.SetBool("isIdel", false);
        }

    }
}
