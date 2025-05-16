using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameNavigation : MonoBehaviour
{
    public GameObject settingsGamePanel, pausePanel;
    
    public void SettingsPanel()
    {
        settingsGamePanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void CloseSettingsPanel()
    {
        settingsGamePanel.SetActive(false);
        pausePanel.SetActive(true);
    }
}
