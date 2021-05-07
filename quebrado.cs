using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quebrado : MonoBehaviour
{
        public static float velocidade=20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                transform.Translate(Vector3.up * Time.deltaTime * velocidade); 

    }
}
