using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKORE : MonoBehaviour
{

    private int score;

    // Start is called before the first frame update

    public void AddScore(int scoreIndex)
    {
        score += scoreIndex;
    }

    public int GetScore()
    {
        return score;
    }

    void Start()
    {
        Debug.Log("Abraka dabra");
    }

}
