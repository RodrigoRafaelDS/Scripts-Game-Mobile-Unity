using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorShap : MonoBehaviour
{
    
    public GameObject[] shap; 
    public GameObject local;
    public static int controle;
    // Start is called before the first frame update

    public void bolinha()
    {
            Instantiate(shap[controle], local.transform.position, local.transform.rotation);
    }

    public void quadrado()
    {
            Instantiate(shap[controle], local.transform.position, local.transform.rotation);
    }

    public void triangulo()
    {
            Instantiate(shap[controle], local.transform.position, local.transform.rotation);
    }



}
