using UnityEngine;

public class InstantiatePrefabs : MonoBehaviour
{
    public GameObject CapsulePrefab; // Variável GameObjet referência para o objeto prefab no inspetor.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Instância um objeto no eixo x = 0, y = 0 e z = 0 na rotação propria do objeto
            Instantiate(CapsulePrefab, new Vector3(0, 0, 0), Quaternion.identity); 
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            // Instância um objeto em uma posição random 0 a 10 no eixo x, 1 no eixo y, 0 a 10 no eixo z. na rotação do proprio objeto.
            Instantiate(CapsulePrefab, new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10)), Quaternion.identity);
        }
    }
}