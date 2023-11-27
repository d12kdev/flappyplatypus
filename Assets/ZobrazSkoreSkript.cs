using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ZobrazSkoreSkript : MonoBehaviour
{

    public TMP_Text text;
    public SKORE skoreScript;


    // Start is called before the first frame update
    void Start()
    {
        text.text = "BAGETY: 0";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "BAGETY: " + skoreScript.GetScore();
    }
}
