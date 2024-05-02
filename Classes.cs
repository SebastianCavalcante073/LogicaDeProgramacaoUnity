using UnityEngine;

public class Classes : MonoBehaviour
{
    // Classe cachorro
    public class Cachorro
    {
        public string Cor;
        public string Nome;

        // Construtor vazio da classe cachorro
        public Cachorro() { }

        // Construtor com argumentos da classe cachorro
        public Cachorro(string cor, string nome)
        {
            Cor = cor;
            Nome = nome;
        }
    }

    private void Start()
    {
        Cachorro cachorro = new Cachorro(); // Instânciando um novo objeto cachorro com construtor vazio
        Cachorro cachorro1 = new Cachorro("Preto", "Bob"); // Instânciando um novo objeto cachorro com construtor com argumentos
    }
}