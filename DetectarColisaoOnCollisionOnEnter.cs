using UnityEngine;

public class DetectarColisaoOnCollision : MonoBehaviour
{
    // OnCollisionEnter ou OnCollisionEnter2D Detecta uma colisão entre objetos com colisores visiveis na cena!
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ItemDeDano") // Verifica se o gameObject que tocou o collisior tem a tag de ItemDeDano.
        {
            Debug.Log("Você perdeu uma vida");
        }
    }
}