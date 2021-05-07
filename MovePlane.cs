using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePlane : MonoBehaviour
{
    // Start is called before the first frame update
    public static float velocidade = 20;
    public GameObject planoQuebrado;
    public static bool trocaFase=false;
    public Material[] cores;
    Renderer render;
    public int ncores;


    void Start() 
    {
        // render = gameObject.GetComponent<Renderer>();
        // ncores=Random.Range(0, 4);
        // render.material = cores[ncores]; 
    } 

    // Update is called once per frame 
    void Update()
    {
        
        if (controlShap.perdeu && !gerador.moverPlataforma)
        {

            transform.Translate(Vector3.forward * Time.deltaTime * 0);
        }
        else if(gerador.moverPlataforma)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * velocidade);
        Destroy(gameObject, 10); 

        }

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Instantiate(planoQuebrado, transform.position, planoQuebrado.transform.rotation);

        }

        if (col.gameObject.CompareTag("shap")&& gameObject.CompareTag("vazio"))
        {
            Destroy(gameObject);
            Instantiate(planoQuebrado, transform.position, planoQuebrado.transform.rotation);

                trocaFase=true;
        }
    }
    // private void OnCollisionEnter(Collision local)
    // {

    //     if (local.gameObject.CompareTag("teto"))
    //     {
    //         Destroy(gameObject);
    //         print("Fim de jogo!");

    //     }
    //     if (local.gameObject.CompareTag("shap"))
    //     {
    //         print("Fim de jogo!");
    //     }

    // }
}
