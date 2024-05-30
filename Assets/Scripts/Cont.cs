using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cont : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        canvas.enabled = false;
    }

    public void Resume()
    {
        canvas.enabled = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            canvas.enabled = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;        
        }      
    }
}
