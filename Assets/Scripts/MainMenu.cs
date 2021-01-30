using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    
   // public AudioMixer audioMixer;
   // public AudioMixer audioEffect;
   /* static public MainMenu Instance

    {
        get
        {
            if (_singletonInstance == null)
            {
                _singletonInstance = GameObject.FindObjectOfType<MainMenu>();
                GameObject container = new GameObject("MainMenuManager");
                _singletonInstance = container.AddComponent<MainMenu>();
            }
            return _singletonInstance;
        }
    }
    static protected MainMenu _singletonInstance = null;
    void Awake()
    {
        if (_singletonInstance == null)
        {
            _singletonInstance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if (this != _singletonInstance)
            {
                Destroy(this.gameObject);
            }
        }
    }*/

    public void PLayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
    }
    public void BackMainMenu()
    {
        Debug.Log("Back to MainMenu");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
  /*  public void Setvolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
       

    }
    public void SetEffectSound(float volume)
    {

       audioEffect.SetFloat("Effect", volume);
    }*/
}
