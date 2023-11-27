using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sloupek : MonoBehaviour
{
    public float Velocity;
    public bool Flip;

    void Start()
    {
        if (Flip)
        {
            Vector3 vec = this.transform.localScale;
            vec.y = -vec.y;
            this.transform.localScale = vec;
        }
    }

    void Update()
    {
        transform.localPosition += Velocity * Time.deltaTime * Vector3.left;
        
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
