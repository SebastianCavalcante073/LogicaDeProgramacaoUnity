using System.Collections.Generic;
using UnityEngine;

public class ConceitoDeDictionary : MonoBehaviour
{
    // Declaração de um dicionario do tipo Ork
   public Dictionary<string, Ork> orkDictionary = new Dictionary<string, Ork>();

    // Start is called before the first frame update
    void Start()
    {
        // Instânciando objetos do tipo Ork
        Ork ork1 = new Ork("Zabura", 52);
        Ork ork2 = new Ork("Feltis", 100);
        Ork ork3 = new Ork("Bordomono", 150);

        // Adicionando os objetos instânciados ao Livro de coleções orkDictionary
        orkDictionary.Add("Mago", ork1);
        orkDictionary.Add("Feiticeiro", ork2);
        orkDictionary.Add("Brutus", ork3);

        // Verificando se na lista possue um mago 
        if (orkDictionary.TryGetValue("Mago", out ork1))
        {
            Debug.Log("Na lista exite um mago");
        }
        else
        {
            Debug.Log("Na lista não existe um mago");
        }
    }
}