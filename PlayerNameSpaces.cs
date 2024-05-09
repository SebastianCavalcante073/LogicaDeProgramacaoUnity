using UnityEngine;

namespace PlayerNameSpace // Declarando um namespace
{
    // Coleção de classes do namespace
    public class Player : MonoBehaviour  
    {
        public int  Vida;
        public float Dano;
    }

    public class Inimigo : MonoBehaviour
    {
        public int Vida;
        public float Dano;
    }
}