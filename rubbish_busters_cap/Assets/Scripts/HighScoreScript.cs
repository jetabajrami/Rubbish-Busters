using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    public GameObject score;
    public GameObject name;
    public GameObject rank;
    public GameObject city;

    public void SetScore(string name, string score, string rank, string city)
    {
        this.rank.GetComponent<TextMesh>().text = rank;
        this.score.GetComponent<TextMesh>().text = score;
        this.name.GetComponent<TextMesh>().text = name;
        this.name.GetComponent<TextMesh>().text = name;


    }


}
