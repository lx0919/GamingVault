using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class platformerbutton : MonoBehaviour
{
    public void StartPlatformer()
    {
        SceneManager.LoadScene("game2");
    }
    
}