using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextTetris : MonoBehaviour
{
    public Image MyIm;
    public Sprite [] nextTetrisIm;
    // Start is called before the first frame update
    void Start()
    {
        MyIm = GetComponent<Image>();
        MyIm.sprite = nextTetrisIm[14];
    }

    // Update is called once per frame
    void Update()
    {
        if (Singleton.Instance.Tetris == 1 || Singleton.Instance.Tetris == 2)
        {
            MyIm.sprite = nextTetrisIm[0];
        }
        else if (Singleton.Instance.Tetris == 3 || Singleton.Instance.Tetris == 4)
        {
            MyIm.sprite = nextTetrisIm[1];
        }
        else if (Singleton.Instance.Tetris == 5 || Singleton.Instance.Tetris == 6)
        {
            MyIm.sprite = nextTetrisIm[2];
        }
        else if (Singleton.Instance.Tetris == 7 || Singleton.Instance.Tetris == 8)
        {
            MyIm.sprite = nextTetrisIm[3];
        }
        else if (Singleton.Instance.Tetris == 9 || Singleton.Instance.Tetris == 10)
        {
            MyIm.sprite = nextTetrisIm[4];
        }
        else if (Singleton.Instance.Tetris == 11 || Singleton.Instance.Tetris == 12)
        {
            MyIm.sprite = nextTetrisIm[5];
        }
        else if (Singleton.Instance.Tetris == 13 || Singleton.Instance.Tetris == 14)
        {
            MyIm.sprite = nextTetrisIm[6];
        }
        else if (Singleton.Instance.Tetris == 15)
        {
            MyIm.sprite = nextTetrisIm[7];
        }
        else if (Singleton.Instance.Tetris == 16)
        {
            MyIm.sprite = nextTetrisIm[8];
        }
        else if (Singleton.Instance.Tetris == 17)
        {
            MyIm.sprite = nextTetrisIm[9];
        }
        else if (Singleton.Instance.Tetris == 18)
        {
            MyIm.sprite = nextTetrisIm[10];
        }
        else if (Singleton.Instance.Tetris == 19)
        {
            MyIm.sprite = nextTetrisIm[11];
        }
        else if (Singleton.Instance.Tetris == 20)
        {
            MyIm.sprite = nextTetrisIm[12];
        }
        else if (Singleton.Instance.Tetris == 21)
        {
            MyIm.sprite = nextTetrisIm[13];
        }
    }
}
