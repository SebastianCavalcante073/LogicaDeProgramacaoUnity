using UnityEngine;

public class EfeitoDeTiroSimples : MonoBehaviour
{
    public GameObject Bullet;      // Referencia para o GameObject da projetil
    public Transform TriigerPoint; // Referencia para o Ponto de disparo onde será instanciado o objeto
    public float SpeedBullet;      // Referencia de Velocidade de movimento do projetil

    private void Update()
    {
        ShootBullet(); // Chama o método que efetua o disparo do projetil.
    }

    void ShootBullet()
    {
        if (Input.GetMouseButtonDown(0)) // Se clicado o botão esquerdo do mouse
        {
            GameObject LocalBullet = Instantiate(Bullet); // Instancia um objeto do tipo Bullet

            LocalBullet.transform.position = TriigerPoint.position; // O objeto LocalBullet recebe a posição onde será instanciado o objeto, neste caso na posiçao do TriigerPosition
            LocalBullet.GetComponent<Rigidbody>().AddForce(transform.forward * SpeedBullet, ForceMode.Impulse); // Adiciona uma força de impulso no objeto instanciado na velocidade SpeedBullet.

            Destroy(LocalBullet, 2f); // Destroi o objeto LocalBullet após 2 segundos.
        }
    }
}