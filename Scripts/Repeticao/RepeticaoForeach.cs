using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeticaoForeach : MonoBehaviour
{
    public string[] pessoas;
    public bool procurar;

    private void Start()
    {
        pessoas = new string[5];
    }
    // Update is called once per frame
    void Update()
    {
        if (procurar)
        {
            foreach (string nome in pessoas)
            {
                Debug.Log(nome);

            }
            procurar = false;
        }
    }
}
