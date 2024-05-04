using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Update � chamado a cada frame do jogo.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject); // Destroi o objeto ao qual esse script est� anexado!
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Destroy(gameObject, Random.Range(1, 5)); // Destroi o objeto ao qual esse script est� anexado de acordo com um tempo random entre 1 e 5 segundos.
        }
    }
}