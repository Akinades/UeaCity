using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour
{
    public AudioClip click;
    [Range(0f, 1f)]
    public float volume = 1f;
    private new AudioSource audio;

    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(() => UIAudio.Play(click, volume));
    }
}
