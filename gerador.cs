using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gerador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] plano;

    public GameObject[] shap;
    public GameObject[] shapParte;
    public GameObject teto, chao, localShap;
    public static float temp = 0, temp2 = 0, gerar = 1.5f, temp3 = 0;
    private int num;
    public static int controle;
    // public RawImage fundo1, fundo2, fundo3;
    public AudioSource erro, quebrar;
    public Text score;
    public static int ponto = 0;
    private bool estado01 = false, criar = false, parar = false, estado = false, mudarNv = false;
    public static bool assistido = false;
    public Canvas uiCanvas, nv2Canvas, nv3Canvas, FimCanvas, menuCanvas, geradorCanvas, ConfCanvas, StoreCanvas, tutorialCanvas;
    public Text ptsText, dinText, dinText2;
    private float pts, din;

    public Image som, semSom;
    private bool estadoSom = false;
    private int nextLevel = 20, nv = 2;
    public static bool moverPlataforma=false;
    public static int ncor=0;

    void Start()
    {

        estadoInicial();
    

    }
    

    void estadoInicial()
    {

        // Time.timeScale = 0;

        controlShap.perdeu = false;
        moverPlataforma=false;
        controle = 0;

        Instantiate(shap[controle], transform.position, chao.transform.rotation);

        TelaMenu();


        if (ads.play)
        {

            Time.timeScale = 1;
            PlayGame();

            ads.play = false;
        }

        pts = memoria.Pontuação();
        din = memoria.Dinheiro();

        ptsText.text = pts.ToString();
        dinText.text = din.ToString();
        dinText2.text = din.ToString();

    }

    void fase()
    {
        if (MovePlane.trocaFase)
        {
            geradorCanvas.enabled = false;
           
            MovePlane.trocaFase = false;
            if (ponto>38)
            {
                nv2Canvas.enabled = false;
                             nv3Canvas.enabled = true;

            }else{
             nv2Canvas.enabled = true;}
        }
    }
    public void store()
    {
        StoreCanvas.enabled = true;

    }

    public void ajustaSom()
    {
        if (AudioListener.pause)
        {
            som.enabled = true;
            semSom.enabled = false;
            estadoSom = false;
            AudioListener.pause = false;

        }
        else
        {
            som.enabled = false;
            semSom.enabled = true;
            estadoSom = true;
            AudioListener.pause = true;


        }

    }

    public void conf()
    {
        ConfCanvas.enabled = true;
        if (AudioListener.pause)
        {
            som.enabled = false;
            semSom.enabled = true;
            estadoSom = false;

        }


    }
    public void sairConf()
    {
        ConfCanvas.enabled = false;
        StoreCanvas.enabled = false;
        tutorialCanvas.enabled = false;


    }
    public void tt()
    {
        tutorialCanvas.enabled = true;

    }
    public void PlayGame()
    {
        Time.timeScale = 1;
        FimCanvas.enabled = false;
        menuCanvas.enabled = false;
        geradorCanvas.enabled = true;
        uiCanvas.enabled = true;
        moverPlataforma=true;
    }

    public void TelaMenu()
    {

        // SceneManager.LoadScene("SampleScene");
        FimCanvas.enabled = false;
        menuCanvas.enabled = true;
        geradorCanvas.enabled = false;
        ConfCanvas.enabled = false;
        StoreCanvas.enabled = false;
        tutorialCanvas.enabled = false;
        nv2Canvas.enabled = false;
        nv3Canvas.enabled = false;
          
        uiCanvas.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
       
            
        conferePonto();
        if (moverPlataforma)
        {
            
        
        geraBase();
        }
        fase();
        
    }


    void geraBase()
    {
        if (!controlShap.perdeu)
        {


            score.text = ponto.ToString();
            temp += Time.deltaTime;
            temp2 += Time.deltaTime;

            if (temp2 >= 3.5f)
            {
                gerar -= .025f;
                temp2 = 0;
                MovePlane.velocidade += .25f;
            }


            if ((temp >= gerar) && !mudarNv)
            {
                num = Random.Range(0, nv);
                Instantiate(plano[num], chao.transform.position, chao.transform.rotation);
                temp = 0;
            }
            else if ((temp >= gerar + 1) && mudarNv)
            {
                mudarNv = false;
                Instantiate(plano[4], chao.transform.position, chao.transform.rotation);
                temp = 0;
               

            }

            teclado();
        }

    }


    void conferePonto()
    {

        if (ponto == nextLevel - 1  && mudarNv==false && nextLevel<41) 
        {
            
            nextLevel=nextLevel+nextLevel;
            
            // geradorCanvas.enabled = false;
            // nv2Canvas.enabled = true;
            nv += 1;
            mudarNv = true;
            ncor=1;
            gerar = 1.5f;
            MovePlane.velocidade =20;

        }

        // if (controlShap.mudar)
        // {
        //     quebrar.Play();
        //     controlShap.mudar = false;
        //     geradorCanvas.enabled = false;
        //     nv2Canvas.enabled = true;
        //     Instantiate(plano[3], chao.transform.position, chao.transform.rotation);
        //     temp = 0;
        //     mudarNv = false;

        // }
        if (controlShap.perdeu)
        {
           
            moverPlataforma=false;
            if (!criar)
            {


                Instantiate(shapParte[controle], transform.position, transform.rotation);
                 Vibration.Vibrate(1000);
                quebrar.Play();

                criar = true;

            }
            temp3 += Time.deltaTime;

            if (temp3 >= 3f)
            {

                temp3 = 0;
                 TelaMenu();
                 gameOver();
                 SceneManager.LoadScene("SampleScene");
                // if (assistido)
                // {
                //     TelaMenu();
                //     gameOver();
                //     SceneManager.LoadScene("SampleScene");

                // }
                // else
                // {
                //     FimCanvas.enabled = true;
                // }



            }


            // Time.timeScale = 0;

        } 



    }






 public void corAzul(){
        ncor=3;
                    Instantiate(shap[controle], transform.position, chao.transform.rotation);
 
    }
    public void corVermelho(){
        ncor=0;
                    Instantiate(shap[controle], transform.position, chao.transform.rotation);
 
    }
    public void corVerde(){
        ncor=1;
                    Instantiate(shap[controle], transform.position, chao.transform.rotation);
 
    }
    public void corAmarelo(){
        ncor=2;
                    Instantiate(shap[controle], transform.position, chao.transform.rotation);
 
    }


    public void bolinha()
    {
        if (!controlShap.perdeu && !parar && controle!=0)
        {
            controle = 0;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);
        }

    }

    public void quadrado()
    {
        if (!controlShap.perdeu && !parar&& controle!=1)
        {
            controle = 1;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);
        }
    }

    public void triangulo()
    {
        if (!controlShap.perdeu && !parar&& controle!=2)
        {
            controle = 2;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);
        }
    }
public void estrela()
    {
        if (!controlShap.perdeu && !parar&& controle!=3)
        {
            controle = 3;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);
        }
    }


    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            parar = true;
        }
        else
        {
            parar = false;

            Time.timeScale = 1;
        }

    }

    public static void gameOver()
    {

        memoria.salvar(ponto, ponto);
        ponto = 0;
        assistido = false;

        MovePlane.velocidade = 20;
        gerar = 1.5f;
        controlShap.perdeu = false;

    }

    public void fimGame()
    {
        TelaMenu();
        gameOver();
        SceneManager.LoadScene("SampleScene");
    }

    public void pagarVida()
    {
       if(memoria.dinheiro>=2){
            PlayerPrefs.SetInt("Dinheiro", memoria.dinheiro -2);
            memoria.dinheiro = PlayerPrefs.GetInt("Dinheiro");
            controlShap.perdeu = false;
            assistido = true;
ads.play=true;
        
     
       }else
       {
           
       }
    }
public void addpt(){
     ponto=nextLevel-1;
}
    void teclado()
    {


        if (Input.GetKeyDown("1"))
        {
            controle = 0;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);

        }

        if (Input.GetKeyDown("2"))
        {
            controle = 1;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);


        }
        if (Input.GetKeyDown("3"))
        {
            controle = 2;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);


        }

        if (Input.GetKeyDown("4"))
        {
            controle = 3;
            Instantiate(shap[controle], transform.position, chao.transform.rotation);
        }

        if (Input.GetKeyDown("0"))
        {
            ponto=nextLevel-1;


        }

    }


}
