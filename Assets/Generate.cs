using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Generator : MonoBehaviour
{
    public GameObject Template;
    public float MinTime, MaxTime;
    public float MinSpace, MaxSpace;
    public Camera MainCamera;

    void Start()
    {
        StartCoroutine(Generate());
    }

    IEnumerator Generate()
    {
        while (true)
        {
            float time = Random.Range(MinTime, MaxTime);
            yield return new WaitForSeconds(time);

            bool flip = Random.value < 0.5f;
            bool both = Random.value < 0.5f;
            GameObject column = Instantiate(Template, this.transform);
            Vector3 vektorOuJEEEE = new Vector3(
                MainCamera.orthographicSize * MainCamera.aspect,
                0.5f * Random.Range(-MainCamera.orthographicSize, MainCamera.orthographicSize),
                0
            );
            column.transform.localPosition = vektorOuJEEEE;

            if (both)
            {
                column = Instantiate(Template, this.transform);
                column.GetComponent<Sloupek>().Flip = true;
                Destroy(column.transform.GetChild(0).gameObject);

                var position = column.transform.localPosition;
                position.y += Random.Range(MinSpace, MaxSpace);
                column.transform.localPosition = position;
            } else
            {
                column.GetComponent<Sloupek>().Flip = flip;
            }


        }
    }
}
