using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


// 4.12
public class PtacekMovement : MonoBehaviour
{

    public float ryyyychlooooost = 2;

    public float force = 200;
    private float negativeForce;

    [SerializeField]
    private Animator _animator;


    // Start is called before the first frame update
    void Start()
    {
        negativeForce = -force;
        GetComponent<Rigidbody2D>().velocity = Vector2.right * ryyyychlooooost;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 4.13 || transform.position.y <= -4.26)
        {
            SceneManager.LoadScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y <= 4.12)
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            _animator.SetTrigger("Jump");
        }
            
        transform.position = new Vector2(-7, transform.position.y);
    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.name.Contains("tycka") || hit.gameObject.name.Contains("generatoromg"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
