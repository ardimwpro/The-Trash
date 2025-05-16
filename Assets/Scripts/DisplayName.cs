using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayName : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = PlayerPrefs.GetString("user_name");
    }

}
