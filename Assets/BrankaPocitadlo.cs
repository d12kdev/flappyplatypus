using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrankaPocitadlo : MonoBehaviour
{

    private SKORE skoreScript;

    private void Start()
    {
        skoreScript = GameObject.FindWithTag("skorepocitadlo").GetComponent<SKORE>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        skoreScript.AddScore(1);
        Debug.Log(skoreScript.GetScore());
        Destroy(this.gameObject);
    }
}
