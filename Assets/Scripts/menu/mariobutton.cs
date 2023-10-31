using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mariobutton : MonoBehaviour
{
    public void StartMario()
    {
        SceneManager.LoadScene("1-1");
    }
    
}