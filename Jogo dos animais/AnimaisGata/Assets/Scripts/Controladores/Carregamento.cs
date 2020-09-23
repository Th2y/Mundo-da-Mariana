using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Carregamento : MonoBehaviour
{
    public GameObject[] dicas;
    public static string cenaACarregar;
    public float TempoFixoSeg = 5;
    public enum TipoCarreg {Carregamento, TempoFixo};
    public TipoCarreg TipoDeCarregamento;
    public Image barraDeCarregamento;
    public Text TextoProgresso;
    private int progresso = 0;
    public static bool novoJogo;

    void Start()
    {
        if (cenaACarregar == "Introducao")
            dicas[0].SetActive(true);
        else if (cenaACarregar == "Fase_01" || cenaACarregar == "Fase_01_2" || cenaACarregar == "Fase_01_3" || cenaACarregar == "Fase_01_4" || cenaACarregar == "Fase_01_5")
            dicas[1].SetActive(true);
        else if (cenaACarregar == "Fase_02" || cenaACarregar == "Fase_02_2" || cenaACarregar == "Fase_02_3" || cenaACarregar == "Fase_02_4" || cenaACarregar == "Fase_02_5")
            dicas[2].SetActive(true);
        else if (cenaACarregar == "Fase_03" || cenaACarregar == "Fase_03_2" || cenaACarregar == "Fase_03_3" || cenaACarregar == "Fase_03_4" || cenaACarregar == "Fase_03_5")
            dicas[3].SetActive(true);
        else if (cenaACarregar == "Fase_04" || cenaACarregar == "Fase_04_2" || cenaACarregar == "Fase_04_3" || cenaACarregar == "Fase_04_4" || cenaACarregar == "Fase_04_5")
            dicas[4].SetActive(true);
        else if (cenaACarregar == "Fase_05" || cenaACarregar == "Fase_05_2" || cenaACarregar == "Fase_05_3" || cenaACarregar == "Fase_05_4" || cenaACarregar == "Fase_05_5")
            dicas[5].SetActive(true);

        novoJogo = true;

            switch (TipoDeCarregamento)
            {
                case TipoCarreg.Carregamento:
                    StartCoroutine(CenaDeCarregamento(cenaACarregar));
                    break;
                case TipoCarreg.TempoFixo:
                    StartCoroutine(TempoFixo(cenaACarregar));
                    break;
            }

            if (barraDeCarregamento != null)
            {
                barraDeCarregamento.type = Image.Type.Filled;
                barraDeCarregamento.fillMethod = Image.FillMethod.Horizontal;
                barraDeCarregamento.fillOrigin = (int)Image.OriginHorizontal.Left;
            }
    }

    IEnumerator CenaDeCarregamento(string cena)
    {
        AsyncOperation carregamento = SceneManager.LoadSceneAsync(cena);
        carregamento.allowSceneActivation = false;
        while (progresso<89)
        {
            progresso = (int) (carregamento.progress * 100.0f);
            yield return null;
        }
        progresso = 100;
        yield return new WaitForSeconds(2);
        carregamento.allowSceneActivation = true;
    }

    IEnumerator TempoFixo(string cena)
    {
        yield return new WaitForSeconds(TempoFixoSeg);
        SceneManager.LoadSceneAsync(cena);
    }

    void Update()
    {
            switch (TipoDeCarregamento)
            {
                case TipoCarreg.Carregamento:
                    break;
                case TipoCarreg.TempoFixo:
                    progresso = (int)(Mathf.Clamp((Time.time / TempoFixoSeg), 0.0f, 1.0f) * 100.0f);
                    break;
            }

            if (TextoProgresso != null)
                TextoProgresso.text = progresso + "%";

            if (barraDeCarregamento != null)
                barraDeCarregamento.fillAmount = (progresso / 100.0f);
    }
}
