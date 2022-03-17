using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private int actualSong;
    public AudioClip[] music;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(music[actualSong]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseButtom()
    {
        audio.Pause();
    }

    public void PlayButtom()
    {
        audio.UnPause();
    }

    public void NextButtom()
    {
        actualSong++;
        audio.PlayOneShot(music[actualSong],1f);

        if (actualSong >= music.Length)
        {
            actualSong = 0;
        }

        audio.Stop();
    }

    public void BackButtom()
    {
        actualSong--;
        audio.PlayOneShot(music[actualSong]);

        if (actualSong <=0)
        {
            actualSong = music.Length -1;
        }

        audio.Stop();
    }



}
