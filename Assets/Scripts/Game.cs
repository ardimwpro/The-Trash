using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public Sprite[] spriteMute; // 
    public Button buttonMute;

    public Slider sliderVolume;
    // Start is called before the first frame update
    void Start()
    {
        if (SoundManager.Instance.music.mute == true)
        {
            buttonMute.image.sprite = spriteMute[1];
        }
        else
        {
            buttonMute.image.sprite = spriteMute[0];
        }

        sliderVolume.value = SoundManager.Instance.music.volume;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SliderVolume()
    {
        SoundManager.Instance.music.volume = sliderVolume.value;

        if (sliderVolume.value <= sliderVolume.minValue)
        {
            SoundManager.Instance.music.mute = true;
        }
        else
        {
            SoundManager.Instance.music.mute = false;
        }
    }

    public void ButtonMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ButtonMute()
    {
        SoundManager.Instance.MuteSound();
        {
            if (SoundManager.Instance.music.mute == true)
            {
                buttonMute.image.sprite = spriteMute[1];
            }
            else
            {
                buttonMute.image.sprite = spriteMute[0];
            }
        }
    }
}
