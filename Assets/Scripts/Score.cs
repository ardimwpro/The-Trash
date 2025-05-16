using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int score;
    public GameObject objectScore;
    Text teksSkor;


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (score >= 50)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
