using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColecoesChaves : MonoBehaviour
{
    public bool listar;

    public string nome;
    public int indice;

    public Dictionary<int, string> alunos = new Dictionary<int, string>()
    {
        { 1, "Susan"},
        { 2, "Yuri"},
        { 3, "Gustavo"},
        { 4, "George"},
        { 5, "Vinicius"},
        { 6, "Pedro"},
        { 7, "George Dantas"},
        { 8, "Laryssa"},
        { 9, "Leandro"},
        { 10, "Luca"},
        { 11, "Andr�"},
        { 12, "Paulo"}
    };



    private void Update()
    {
        if (listar)
        {
            if (alunos.ContainsKey(indice))
            {
                Debug.Log(indice + " - " + alunos[indice]);
            }
            listar = false;
        }
    }
}
