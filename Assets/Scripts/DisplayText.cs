﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{

    public Text obj_text;
    public Text obj_textInGame;
    public InputField display;


    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("user_name");
        obj_textInGame.text = PlayerPrefs.GetString("user_name");
    }

    public void Create()
    {
        obj_text.text = display.text;
        obj_textInGame.text = display.text;
        PlayerPrefs.SetString("user_name", obj_text.text);
        PlayerPrefs.SetString("user_name", obj_textInGame.text);
        PlayerPrefs.Save();
    }

}