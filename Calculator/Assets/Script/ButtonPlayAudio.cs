using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlayAudio : MonoBehaviour
{
    public void Play(int Play)
    {
        SoundManager.instance.Play(Play);
    }
}
