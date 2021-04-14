using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    public GameObject GaemOver;
    private void Start()
    {
        fire1.SetActive(false);
        fire2.SetActive(false);
        fire3.SetActive(false);
    }
    void Update()
    {
        if(Singleton.Instance.Score < 0)
        {
            GaemOver.SetActive(true);
        }
        if(Singleton.Instance.Fevercount == 2)
        {
            fire1.SetActive(true);
        }
        else if (Singleton.Instance.Fevercount == 3)
        {
            fire2.SetActive(true);
            fire1.SetActive(false);
        }
        else if (Singleton.Instance.Fevercount >= 4)
        {
            fire2.SetActive(false);
            fire3.SetActive(true);
        }
        else
        {
            fire1.SetActive(false);
            fire2.SetActive(false);
            fire3.SetActive(false);
        }
        if (Singleton.Instance.CharMove == true)
        {
            fire1.transform.position = new Vector3(-1.39f, fire1.transform.position.y, 0);
            fire2.transform.position = new Vector3(-1.39f, fire1.transform.position.y, 0);
            fire3.transform.position = new Vector3(-1.39f, fire1.transform.position.y, 0);
        }
        else
        {
            fire1.transform.position = new Vector3(1.39f, fire1.transform.position.y, 0);
            fire2.transform.position = new Vector3(1.39f, fire1.transform.position.y, 0);
            fire3.transform.position = new Vector3(1.39f, fire1.transform.position.y, 0);
        }
    }
}
