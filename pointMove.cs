using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointMove : MonoBehaviour
{
    public float escala = 474, deslocamento,pontos = 100;
    // Start is called before the first frame update
    void Start()
    {
        deslocamento = escala / pontos;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3((deslocamento*gerador.ponto)-228,850,132);
    }
}
