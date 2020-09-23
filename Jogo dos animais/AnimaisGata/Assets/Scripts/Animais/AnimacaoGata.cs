using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimacaoGata : MonoBehaviour
{
    private Animator gataAnimator;
    private string fase;

    void Start()
    {
        fase = SceneManager.GetActiveScene().name;
        gataAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (PausarParaPerguntar.emPergunta == false)
        {
            if (Gata.horizontal != 0)
            {
                if(fase == "Fase_02" || fase == "Fase_02_2" || fase == "Fase_02_3" || fase == "Fase_02_4" || fase == "Fase_02_5")
                    gataAnimator.SetInteger("grass", (int)Gata.velocidadeX);
                else
                    gataAnimator.SetInteger("h", (int)Gata.velocidadeX);
            }
            else
            {
                if (fase == "Fase_02" || fase == "Fase_02_2" || fase == "Fase_02_3" || fase == "Fase_02_4" || fase == "Fase_02_5")
                    gataAnimator.SetInteger("grass", 0);
                else
                    gataAnimator.SetInteger("h", 0);
            }
        }

        else
        {
            if (fase == "Fase_02" || fase == "Fase_02_2" || fase == "Fase_02_3" || fase == "Fase_02_4" || fase == "Fase_02_5")
                gataAnimator.SetInteger("grass", 0);
            else
                gataAnimator.SetInteger("h", 0);
        }
    }
}
