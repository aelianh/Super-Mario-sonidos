using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour

{
    //variable para acceder al AudioSource
    private AudioSource _audioSoucer;

    void Awake()
    {
        _audioSoucer = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //reproduccion de bgm
        
        _audioSoucer.Play();
    }

    //funcion para parar la bgm
   public void StopBGM()
   {
       _audioSoucer.Stop();
   }
}
