using UnityEngine;

public class Metodos : MonoBehaviour
{
    int vida = 100;

    // Exemplo de m�todos em c#
    public void AumentarVida() // Esse m�todo aumenta a vida em mais 5 quando chamado caso a vida seja menor que 100
    {
        if (vida < 100)
        {
            vida += 5;
        }
    }

    public void DiminuirVida() // Esse m�todo diminui a vida em 5 toda vez que chamado
    {
        vida -= 5;
    }
}