using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BTNSCRIPT : MonoBehaviour
{
    private void Start()
    {
        
    }
    public void tryAgain()
    {
        SceneManager.LoadScene(0);
    }
}
