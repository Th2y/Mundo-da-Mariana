using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeMusica : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource musicWon;
    public AudioSource musicLost;

    public AudioClip musicaVenceu, musicaPerdeu;
    public AudioClip[] musicaComendo;

    private void Update()
    {
        if (Venceu.musica)
        {
            TrocarMusicaVenceu();
            Venceu.musica = false;
        }
        if (Temporizador.musica)
        {
            TrocarMusicaPerdeu();
        }
    }

    private void TrocarMusicaVenceu()
    {
        musicWon.PlayOneShot(musicaVenceu);
        musicSource.Pause();
    }

    private void TrocarMusicaPerdeu()
    {
        musicSource.Pause();
    }
}
