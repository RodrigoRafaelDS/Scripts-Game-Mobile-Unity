using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class compras : MonoBehaviour
{
   void comprarVida(){
       if(memoria.dinheiro>50){
            PlayerPrefs.SetInt("Dinheiro", memoria.dinheiro -50);
            memoria.dinheiro = PlayerPrefs.GetInt("Dinheiro");
     
       }else
       {
           
       }
   }
}
