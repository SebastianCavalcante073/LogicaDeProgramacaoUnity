using UnityEngine;

public class InstantiatePrefabs : MonoBehaviour
{
    public GameObject CapsulePrefab; // Vari�vel GameObjet refer�ncia para o objeto prefab no inspetor.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Inst�ncia um objeto no eixo x = 0, y = 0 e z = 0 na rota��o propria do objeto
            Instantiate(CapsulePrefab, new Vector3(0, 0, 0), Quaternion.identity); 
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            // Inst�ncia um objeto em uma posi��o random 0 a 10 no eixo x, 1 no eixo y, 0 a 10 no eixo z. na rota��o do proprio objeto.
            Instantiate(CapsulePrefab, new Vector3(Random.Range(0, 10), 1, Random.Range(0, 10)), Quaternion.identity);
        }
    }
}