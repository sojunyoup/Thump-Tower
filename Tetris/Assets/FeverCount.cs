using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeverCount : MonoBehaviour
{
    int count;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //병운
        if (count == 0)
        {
            if (collision.gameObject.tag == "Tetris" || collision.gameObject.tag == "Floor")
            {
                Singleton.Instance.Score += 1;
                Singleton.Instance.Fevercount += 1;
                if (Singleton.Instance.Fevercount >= 4)
                    Singleton.Instance.Score += 1;
                gameObject.GetComponent<FeverCount>().enabled = true;
                count++;
            }
        }
        //끝
    }
}
