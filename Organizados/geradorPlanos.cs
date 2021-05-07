using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorPlanos : MonoBehaviour
{
    private float tempo,tempoDeGeração=3.5f;
    private int num,nivelGame=2;
    public GameObject chao;
    public GameObject[] plano;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gerarPlano();
    }



    void gerarPlano(){

        tempo += Time.deltaTime;

       /// Gera 
            if (tempo >= tempoDeGeração){
                num = Random.Range(0, nivelGame);
                Instantiate(plano[num], chao.transform.position, chao.transform.rotation);
                tempo = 0;

                /// Acelera
                tempoDeGeração -= .05f;
                // MovePlane.velocidade += .5f;
            }

    }
}
