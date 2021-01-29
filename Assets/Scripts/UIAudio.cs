using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAudio : MonoBehaviour
{
    public static UIAudio singleton
    {
        get
        {
            if (_singleton == null)
            {
                var go = new GameObject("UI AUDIO");
                var audio = go.AddComponent<AudioSource>();
                audio.playOnAwake = false;
                audio.spatialBlend = 0f;
                audio.volume = 1f;

                _singleton = go.AddComponent<UIAudio>();
                _singleton.audio = audio;
            }

            return _singleton;
        }
    }
    public static UIAudio _singleton;
    new AudioSource audio;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void Play(AudioClip clip, float volume)
    {
        singleton.audio.PlayOneShot(clip, volume);
    }
}
