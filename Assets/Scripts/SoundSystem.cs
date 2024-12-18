using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSystem : MonoBehaviour, ISound
{
    [SerializeField] AudioSource sound;

    public void Sound()
    {
        sound.Play();
    }

    public void Njam()
    {

    }
}
