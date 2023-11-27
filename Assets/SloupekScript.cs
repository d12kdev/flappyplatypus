using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SloupekScript : MonoBehaviour
{
    public float VELOCITYHAHAHAHHAHAHAHAHAHAHAHHAHAHA;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - VELOCITYHAHAHAHHAHAHAHAHAHAHAHHAHAHA * Time.deltaTime, transform.position.y);
    }
}
