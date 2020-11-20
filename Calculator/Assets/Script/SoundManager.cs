using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip[] AudioList;

    List<AudioSource> Source = new List<AudioSource>();
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        for (int i = 0; i< AudioList.Length; i++)
        {
            Source.Add(new AudioSource());
            Source[i] = gameObject.AddComponent<AudioSource>();
            Source[i].clip = AudioList[i];
        }
    }

    // Update is called once per frame
    public void Play(int Sound)
    {
        Source[Sound].Play();
    }
}
