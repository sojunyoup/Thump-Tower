using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharUp : MonoBehaviour
{
    public GameObject UpButton;

    private void Update()
    {
            Debug.Log(Singleton.Instance.isUpCharButton);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Tetris")
        {
            Singleton.Instance.isUpCharButton = true;
            UpButton.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Tetris")
        {
            UpButton.SetActive(false);
            Singleton.Instance.isUpCharButton = false;
        }
    }
}
