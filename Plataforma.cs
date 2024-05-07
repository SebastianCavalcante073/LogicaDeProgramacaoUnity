using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float Velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5f); // Destroi este objeto gameObject 5 segundos depois de instânciado.
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Velocidade * Time.deltaTime); // Movimenta o objeto gameObject no eixo x.
    }
}