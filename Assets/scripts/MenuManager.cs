using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider masterSlider;

    void Start()
    {
        if (masterSlider != null && masterSlider.isActiveAndEnabled)
        {
            masterSlider.value = PreferencesManager.GetMasterVolume();
        }

        if (musicSlider != null && musicSlider.isActiveAndEnabled)
        {
            musicSlider.value = PreferencesManager.GetMusicVolume();
        }
    }

    public void ChangeSoundVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeSoundVolume(soundLevel);
    }

    public void ChangeMusicVolume(float soundLevel)
    {
        AudioManager.Instance.ChangeMusicVolume(soundLevel);
    }
public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
