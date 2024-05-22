using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip BackgroundMusic; // Refencia para a musica do jogo
    public AudioClip EfectSound1;     // Referencia para um efeito sonoro
    public AudioClip EfectSound2;     //Referencia para outro efeito sonoro

    private AudioSource AudioSource; // Referencia ao component AudioSource da camera

    public static AudioController instance; // Torna a classe AudioController estatica, em outras palavras, torna a classe AudioController visivel para todos os scripts

    private void Start()
    {
        instance = this; // Chama a propria classe 

        AudioSource = GetComponent<AudioSource>(); // Captura o component AudioSource e o instancia
    }

    public void PlayerMusic(AudioClip clip) // Toca um som de acordo com o som passado por parametro
    {
        AudioSource.PlayOneShot(clip); // Toca o som
    }
}