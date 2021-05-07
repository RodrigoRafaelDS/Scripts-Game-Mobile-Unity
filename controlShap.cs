using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class controlShap : MonoBehaviour
{
    // Start is called before the first frame update
    private int anterior;
    private float temp;
    public Material padrao, brilhando;
    Renderer rend;
    private bool a = true;
    public static bool perdeu = false,mudar=false;
    public AudioSource passar;
    public Material[] cor;
    public int i=3, confCor;

 

    void Start()
    {
        anterior = gerador.controle;
        confCor=gerador.ncor;
        rend = gameObject.GetComponent<Renderer>();
       passar = gameObject.GetComponent<AudioSource>();
        // rend.material = cor[gerador.ncor];
        
        perdeu = false;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (anterior != gerador.controle  || gerador.ncor!= confCor)
        {
            anterior = gerador.controle;

            Destroy(gameObject); 

        }
       

    }

    // public void corAzul(){
    //     rend.material = cor[0];
    // }
    // public void corVermelho(){
    //     rend.material = cor[1];
    // }
    // public void corVerde(){
    //     rend.material = cor[2];
    // }
    // public void corAmarelo(){
    //     rend.material = cor[3];
    // }

   

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("quadrado")) 
        {
            // print(col.gameObject.CompareTag);

            if (gerador.controle != 1)
            {
                perdeu = true;
            Destroy(gameObject);

            } 
            else 
            {
                gerador.ponto += 1;
                Vibration.Vibrate(100);
                passar.Play();
            }

        }
        if (col.gameObject.CompareTag("triangulo"))
        {
            if (gerador.controle != 2)
            {

                perdeu = true;
            Destroy(gameObject);


            }
            else 
            {
                gerador.ponto += 1;
                // Vibration.Vibrate(100);
                passar.Play();

            }

        }
        if (col.gameObject.CompareTag("cilindro"))
        {

            
            // print(col.GetComponent<ncores>());
            // print(col.gameObject.ncores);
            
            if (gerador.controle != 0)
            {
                perdeu = true;
            Destroy(gameObject);

            }
            else 
            {
                gerador.ponto += 1;
                // Vibration.Vibrate(100);
                passar.Play();

            }

        }


        if (col.gameObject.CompareTag("estrela"))
        {
            if (gerador.controle != 3)
            {
                perdeu = true;
            Destroy(gameObject);

            }
            else
            {
                gerador.ponto += 1;
                // Vibration.Vibrate(100);
                passar.Play();

            }

        }

        if (col.gameObject.CompareTag("vazio")) 
        {
            
                mudar=true;
                Vibration.Vibrate(1000);
        
        }


    }




}



//  void Start()
//     {
//         anterior = gerador.controle;
//         rend = gameObject.GetComponent<Renderer>();
//        passar = gameObject.GetComponent<AudioSource>();
//         rend.material = brilhando;
//         perdeu = false;
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
       
//         temp += Time.deltaTime;
//         if (temp >= .4f && a)
//         {
//             rend.material = padrao;
//             a = false;
//         }
//         if (anterior != gerador.controle)
//         {
//             anterior = gerador.controle;

//             Destroy(gameObject); 

//         }
       

//     }