using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public Slider musicSlider;
    public Slider masterSlider;
    public Slider sensitivitySlider;

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
        if (sensitivitySlider != null && sensitivitySlider.isActiveAndEnabled)
        {
            sensitivitySlider.value = PreferencesManager.GetMouseSensitivity();
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
    public void ChangeMouseSensitivity(float sensitivityLevel)
    {
        PreferencesManager.SetMouseSensitivity(sensitivityLevel);
    }
    public void PlayGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
