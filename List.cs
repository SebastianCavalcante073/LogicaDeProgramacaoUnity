using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    // Trabalhando com listas
    List<string> ListaDeNPCs = new List<string>(); // Declara uma lista do tipo string

    private void Start()
    {
        // Adicionando itens na lista
        ListaDeNPCs.Add("Jonas");
        ListaDeNPCs.Add("Gabriel");
        ListaDeNPCs.Add("Hazo");
        ListaDeNPCs.Add("Tatugo");
        ListaDeNPCs.Add("Bazam");

        // Percorrendo a lista e imprimindo no debug.log
        foreach (string npcs in ListaDeNPCs)
        {
            Debug.Log(npcs);
        }
    }
}