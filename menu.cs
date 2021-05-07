using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menu : MonoBehaviour
{
    // // Start is called before the first frame update
    // public Canvas canvas1, canvas2, canvas3, canvas4, canvas5, canvasFase;
    // public Animator cam;
    // public static int trocaC = 0;
    // private float temp = 0, pts, din;
    // public Text ptsText, dinText;

    // public void carregarCena()
    // {

    //     SceneManager.LoadScene("SampleScene");
    // }

    // public void fase()
    // {

    //     trocaC = 1;
    //     cam.SetBool("trocaCam", true);



    //     // SceneManager.LoadScene(nomeDaCena);
    // }
    // public void conf()
    // {
    //     trocaC = 2;
    //     //SceneManager.LoadScene(nomeDaCena);
    //     cam.SetBool("trocaCam", true);
    // }
    // public void ajuda()
    // {

    //     trocaC = 3;
    //     cam.SetBool("trocaCam", true);

    //     //SceneManager.LoadScene(nomeDaCena);
    // }



    // public void sair()
    // {

    //     trocaC = 4;
    //     cam.SetBool("trocaCam", false);

    //     //SceneManager.LoadScene(nomeDaCena);
    // }

    // public void Trocafase()
    // {

    //     trocaC = 5;
    //     cam.SetBool("trocaCam", true);

    //     //SceneManager.LoadScene(nomeDaCena);
    // }
    // void Start()
    // {
    //     canvas1.enabled = false;
    //     canvas2.enabled = false;
    //     canvas3.enabled = false;
    //     canvas4.enabled = false;
    //     canvas5.enabled = true;
    //     canvasFase.enabled = false;

    //     pts = memoria.Pontuação();
    //     din = memoria.Dinheiro();

    //     ptsText.text = pts.ToString();
    //     dinText.text = din.ToString();



    // }
    // void Update()
    // {
    //     temp += Time.deltaTime;
    //     if (temp > 3)
    //     {
    //         canvas1.enabled = true;

    //     }
    //     if (trocaC == 1)
    //     {
    //         canvas5.enabled = false;

    //         canvas1.enabled = false;
    //         canvas2.enabled = true;
    //         canvas3.enabled = false;
    //         canvas4.enabled = false;
    //         canvasFase.enabled = false;

    //     }
    //     if (trocaC == 2)
    //     {
    //         canvas5.enabled = false;

    //         canvas1.enabled = false;
    //         canvas2.enabled = false;
    //         canvas3.enabled = true;
    //         canvas4.enabled = false;
    //         canvasFase.enabled = false;

    //     }
    //     if (trocaC == 3)
    //     {
    //         canvas5.enabled = false;

    //         canvas1.enabled = false;
    //         canvas2.enabled = false;
    //         canvas3.enabled = false;
    //         canvas4.enabled = true;
    //         canvasFase.enabled = false;

    //     }
    //     if (trocaC == 4)
    //     {
    //         canvas5.enabled = true;

    //         canvas1.enabled = true;
    //         canvas2.enabled = false;
    //         canvas3.enabled = false;
    //         canvas4.enabled = false;
    //         canvasFase.enabled = false;

    //     }
    //     if (trocaC == 5)
    //     {
    //         canvas5.enabled = false;

    //         canvas1.enabled = false;
    //         canvas2.enabled = false;
    //         canvas3.enabled = false;
    //         canvas4.enabled = false;
    //         canvasFase.enabled = true;

    //     }
    // }
}
