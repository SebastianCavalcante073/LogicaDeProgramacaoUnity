using UnityEngine;

public class EfeitoDeTiroSimples : MonoBehaviour
{
    public GameObject Bullet;      // Referencia para o GameObject da projetil
    public Transform TriigerPoint; // Referencia para o Ponto de disparo onde ser� instanciado o objeto
    public float SpeedBullet;      // Referencia de Velocidade de movimento do projetil

    private void Update()
    {
        ShootBullet(); // Chama o m�todo que efetua o disparo do projetil.
    }

    void ShootBullet()
    {
        if (Input.GetMouseButtonDown(0)) // Se clicado o bot�o esquerdo do mouse
        {
            GameObject LocalBullet = Instantiate(Bullet); // Instancia um objeto do tipo Bullet

            LocalBullet.transform.position = TriigerPoint.position; // O objeto LocalBullet recebe a posi��o onde ser� instanciado o objeto, neste caso na posi�ao do TriigerPosition
            LocalBullet.GetComponent<Rigidbody>().AddForce(transform.forward * SpeedBullet, ForceMode.Impulse); // Adiciona uma for�a de impulso no objeto instanciado na velocidade SpeedBullet.

            Destroy(LocalBullet, 2f); // Destroi o objeto LocalBullet ap�s 2 segundos.
        }
    }
}