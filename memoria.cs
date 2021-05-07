using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memoria : MonoBehaviour
{
    // Start is called before the first frame update
    public static int pontoMax, dinheiro, divDin=10;


    // Update is called once per frame
  
    public static float Pontuação()
    {
        pontoMax = PlayerPrefs.GetInt("Pontuação Máxima");
        return pontoMax;
    }
    public static float Dinheiro()
    {
        dinheiro = PlayerPrefs.GetInt("Dinheiro");
        return dinheiro;
    }
    public static void salvar(int pt, int dd)
    {
        if (pt > pontoMax)
        {
            PlayerPrefs.SetInt("Pontuação Máxima", pt);

        }
        PlayerPrefs.SetInt("Dinheiro", dinheiro + dd/divDin);

    }
}
