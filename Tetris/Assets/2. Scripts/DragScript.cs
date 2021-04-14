using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragScript : MonoBehaviour
{
    Camera m_cam = null;

    Vector2 t_mousePos1;

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            m_cam = Camera.main;

            t_mousePos1 = m_cam.ScreenToWorldPoint(Input.mousePosition);

        }
        if(Input.GetMouseButtonUp(0))
        {
            Vector2 t_mousePos2 = m_cam.ScreenToWorldPoint(Input.mousePosition);

            Singleton.Instance.ShotPower = t_mousePos1.y - t_mousePos2.y;

            Singleton.Instance.count = true;

        }
    }
}
