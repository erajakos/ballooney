using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int gemsCollected;
    public int totalGems;
    public Text score;

    private void Awake()
    {
        totalGems = GameObject.FindGameObjectsWithTag("Gem").Length;
        gemsCollected = 0;
        score.text = "0 / " + totalGems;
    }

    public void CollectGem()
    {
        Debug.Log("here");
        gemsCollected += 1;
        score.text = gemsCollected + " / " + totalGems;
    }
}
