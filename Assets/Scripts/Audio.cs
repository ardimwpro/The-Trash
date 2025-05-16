using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource lagu;

    public void mulai()
    {
        lagu.Play();
    }

    public void stoplagu()
    {
        lagu.Stop();
    }

}