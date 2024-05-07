using System.Collections.Generic;
using UnityEngine;

public class SpawnerDeObjetos : MonoBehaviour
{
    public List<GameObject> ListaDePlataformas = new List<GameObject>();  // Lista de Plataformas 
    public float SpawnerTime;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        /* Instância randomicamente um objeto da lista ListaDePlataformas na posição x e y do objeto Spawner.
         */
        Instantiate(ListaDePlataformas[Random.Range(0, ListaDePlataformas.Count)], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= SpawnerTime)
        {
            PlataformInstance();
            time = 0;
        }
    }

    void PlataformInstance()
    {
        /* Instância randomicamente um objeto da lista ListaDePlataformas na posição x e y do objeto Spawner.
         */
        Instantiate(ListaDePlataformas[Random.Range(0, ListaDePlataformas.Count)], transform.position, transform.rotation);
    }
}