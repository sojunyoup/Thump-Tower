using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public bool isPausePanel;
    public GameObject PausePanel;
    public GameObject uP;
    public GameObject cemara;
    public float speed;

 
    public void LmoveChar()
    {
        Singleton.Instance.CharMove = true;
        Singleton.Instance.isAttack = false;
    }
    public void RturnButton()
    {
        Singleton.Instance.RTurn = true;
        Singleton.Instance.CanAttack = false;
        Singleton.Instance.isAttack = false;
    }
    public void LturnButton()
    {
        Singleton.Instance.LTurn = true;
        Singleton.Instance.CanAttack = false;
        Singleton.Instance.isAttack = false;
    }
    public void RmoveChar()
    {
        Singleton.Instance.CharMove = false;
        Singleton.Instance.isAttack = false;
    }
    public void Pause()
    {
        if (!isPausePanel)
        {
            isPausePanel = true;
            Time.timeScale = 0.0f;
            PausePanel.SetActive(isPausePanel);
        }
        Singleton.Instance.isAttack = false;

    }
    public void Strat()
    {
        SceneManager.LoadScene("Ingame");
    }
    public void Continue()
    {
        if (isPausePanel)
        {
            isPausePanel = false;
            Time.timeScale = 1.0f;
            PausePanel.SetActive(isPausePanel);
        }
    }

    public void Return()
    {
        SceneManager.LoadScene("Ingame");
        Singleton.Instance.Score = 0;
        Time.timeScale = 1.0f;
        Singleton.Instance.CharMove = false;
    }

    public void charUp()
    {
        if(Singleton.Instance.isUpCharButton == true)
        {
            uP.transform.position = new Vector3(uP.transform.position.x, Mathf.Lerp(uP.transform.position.y, uP.transform.position.y + 50f, Time.deltaTime * speed), uP.transform.position.z);
            cemara.transform.position = new Vector3(cemara.transform.position.x, Mathf.Lerp(cemara.transform.position.y, cemara.transform.position.y + 50f, Time.deltaTime * speed), cemara.transform.position.z);
            Singleton.Instance.isTetrisMoveUp = true;
        }
    }
}
