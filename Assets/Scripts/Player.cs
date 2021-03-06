using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private SFXManager sfxManager;
    private BGMmanager bgmManager;

    void Awake()
    {
        sfxManager = GameObject.Find ("SFXManager").GetComponent<SFXManager>();
        bgmManager = GameObject.Find ("BGMmanager").GetComponent<BGMmanager>();
    }

    public void DeathMario()

    {
        sfxManager.DeathSound();
        bgmManager.StopBGM();

    }
    //funcion matar goombas
    public void DeathGoomba(GameObject goomba)
    {
        Animator goombaaAnimator;

        enemy goombaScript;

        BoxCollider2D goombaCollider;

        goombaScript = goomba.GetComponent<enemy>();
        goombaaAnimator = goomba.GetComponent<Animator>();
        goombaCollider = goomba.GetComponent<BoxCollider2D>();
        //cambiamos a la animacion de muerte
        goombaaAnimator.SetBool("goombadeath", true);

        goombaScript.isAlive = false;

        goombaCollider.enabled = false;
        //destruimos goomba
        Destroy(goomba, 0.3f);

        //llamamos la funcion de sonido de muerte de goomba
        sfxManager.GoombaSound();
    }
     public void coin(GameObject moneda)
     {
         Destroy(moneda);
         sfxManager.CoinSound();
     }
     public void VictoriaBandera()
     {
         sfxManager.BanderaSound();
         bgmManager.StopBGM();
     }
     public void BanderaFinal(GameObject bandera)
     {
         BoxCollider2D banderaCollider;
         banderaCollider = bandera.GetComponent<BoxCollider2D>();
         sfxManager.BanderaSound();
     }
         
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      