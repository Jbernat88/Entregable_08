using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
 

public class AudioManager : MonoBehaviour
{
    private int actualSong;//Array (lista de canciones)
    public AudioClip[] music;
    private AudioSource audio;
    public TextMeshProUGUI songTitle;//Variable para acceder al titulo
    public string[] nameSong;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.PlayOneShot(music[actualSong]);
    }

    // Update is called once per frame
    void Update()
    {
        songTitle.text = nameSong[actualSong]; //Canvia el titulo de la cancion dependio de la canci�n que suena
    }

    //Funcion para pausar la canci�n
    public void PauseButtom()
    {
        audio.Pause();
    }

    //Funci�n para reaunudar la canci�n
    public void PlayButtom()
    {
        audio.UnPause();
    }

    //Funcion para Pasar a la siguiente canci�n de la lista
    public void NextButtom()
    {
        actualSong++;

        if (actualSong >= music.Length)
        {
            actualSong = 0;
        }

        audio.Stop();
        audio.PlayOneShot(music[actualSong], 1f);

    }

    //Funci�n para volver a la anterior canci�n de la lista
    public void BackButtom()
    {
        actualSong--;
   
        if (actualSong <=0)
        {
            actualSong = music.Length -1;
        }

        audio.Stop();
        audio.PlayOneShot(music[actualSong]);
    }

    //Funci�n para Reproducir una canci�n random de la lista
    public void ShuffleButtom()
    {
        
     audio.Stop();
     actualSong = Random.Range(0, music.Length);
     audio.PlayOneShot(music[actualSong]);

    }

}
