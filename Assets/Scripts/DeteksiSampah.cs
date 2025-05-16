using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class DeteksiSampah : MonoBehaviour
{
    public string nameTag;
    public AudioClip audiobenar;
    public AudioClip audiosalah;
    public AudioSource Mediaplayerbenar;
    public AudioSource Mediaplayersalah;
    public Text textscore;
    public Data data;
    // Start is called before the first frame update
    void Start()
    {
        Mediaplayerbenar = gameObject.AddComponent<AudioSource>();
        Mediaplayerbenar.clip = audiobenar;

        Mediaplayersalah = gameObject.AddComponent<AudioSource>();
        Mediaplayersalah.clip = audiosalah;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals(nameTag))
        {
            data.score += 10;
            textscore.text = data.score.ToString();
            Destroy(collision.gameObject);
            Mediaplayerbenar.Play();

            if (data.score >= 100)
            {
                SceneManager.LoadScene("Win");
            }
        }
        else
        {
            data.score -= 25;
            textscore.text = data.score.ToString();
            Destroy(collision.gameObject);
            Mediaplayersalah.Play();

            if (data.score <= -50)
            {
                SceneManager.LoadScene("GameOver");
            }

        }
    }
}