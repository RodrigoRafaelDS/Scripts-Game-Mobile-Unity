using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telas : MonoBehaviour
{
     public Canvas pauseCanvas,uiCanvas, nv2Canvas, FimCanvas, menuCanvas, geradorCanvas, ConfCanvas, StoreCanvas, tutorialCanvas;

    void start(){
        estadoInicial();

    }

     void estadoInicial(){
         
        FimCanvas.enabled = false;
        menuCanvas.enabled = true;
        geradorCanvas.enabled = false;
        ConfCanvas.enabled = false;
        StoreCanvas.enabled = false;
        tutorialCanvas.enabled = false;
        nv2Canvas.enabled = false;
        uiCanvas.enabled = false;
        
     }


      public void store()
    {
        StoreCanvas.enabled = true;

    }


     public void conf()
    {
        ConfCanvas.enabled = true;
        
    }
public void tutorial()
    {
        tutorialCanvas.enabled = true;

    }

    public void sairConf()
    {
        estadoInicial();


    }

     public void PlayGame()
    {
        FimCanvas.enabled = false;
        menuCanvas.enabled = false;
        geradorCanvas.enabled = true;
        uiCanvas.enabled = true;
    }


     public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            pauseCanvas.enabled = true;
          
        }
        else
        {
            pauseCanvas.enabled = false;
            Time.timeScale = 1;
        }

    }
}
