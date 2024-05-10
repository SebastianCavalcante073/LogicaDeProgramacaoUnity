using UnityEngine;

public class Atributos : MonoBehaviour
{
    // -- Exemplos de Atributos Organizadores na Unity.  -- \\

    /* Atributos
        Header, Cria um cabe�alho no inspetor.
        SerializeField, Torna visivel uma vari�vel privada no inspetor.
        Tooltip, Cria um texto sobre a vari�vel.
        Space, Insere um espa�o entre as vari�veis no inspetor.
        TextArea, Define um campo de texto maior para vari�veis.
        Range, Define um valor minimo e maximo de uma vari�vel.

        Outros atributos podem ser consultados na documenta��o Unity.
        https://docs.unity3d.com/Manual/Attributes.html
    */

    [Header("Vari�veis Privadas")]
    [SerializeField]
    [Tooltip("Define a vida")] private int Vida;

    [Space]
    [Header("Vari�veis Publicas")]
    [Tooltip("Define o dano")] public float Dano;
    [Tooltip("Define a velocidade")] public float Velocidade;

    [Space]
    [Header("Outras Vari�veis")]
    [Tooltip("Define o nome do player")] public string PlayerName;

    [Space]
    [Header("Descri��o do player")]
    [Space]
    [Tooltip("Define a descri��o do player! ")][TextArea] public string Descricao;

    [Tooltip("Defini qual skin padr�o do player ")][Range(1, 10)] public int PlayerSkins;
}