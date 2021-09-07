using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCLevelTwo : MonoBehaviour
{
    public TextMeshProUGUI NPCText;
    public GameObject UIPanel;
    public Animator PlayerAnim;
    public Animator[] Cheer;
    public TextMeshProUGUI[] ButtonText;
    int count;

    public GameObject CorrectText;
    public GameObject WrongText;
    public GameObject GuessTheWord;

    public ParticleSystem[] confetti;

    void Start()
    {
        count = 1;
        PlayerAnim.SetTrigger("handup");
        StartCoroutine(UIShow());
    }


    IEnumerator UIShow()
    {
       
        yield return new WaitForSeconds(2f);
        NPCText.transform.parent.gameObject.SetActive(true);
        switch (count)
        {
            case 1:
                NPCText.text = "Not cat but…";
                break;

            case 2:
                NPCText.text = "You peel it..";
                ButtonText[0].text = "Banana";
                ButtonText[1].text = "Mango";
                ButtonText[2].text = "Lemon";
                ButtonText[3].text = "Orange";
                break;

            case 3:
                NPCText.text = "Animal With One Horn";
                ButtonText[0].text = "Impala";
                ButtonText[1].text = "Unicorn";
                ButtonText[2].text = "Rhino";
                ButtonText[3].text = "pass";
                break;

            case 4:
                NPCText.text = "Pass";
                break;
        }
        yield return new WaitForSeconds(1f);
        UIPanel.SetActive(true);
    }

    public void Change(Image image)
    {
        StartCoroutine(ChaageCard(image));
       
    }

    IEnumerator ChaageCard(Image image)
    {
        foreach (Animator anim in Cheer)
        {
            confettiPlay();
            image.gameObject.SetActive(true);
            if (Random.Range(0, 2) == 0)
            {
                anim.SetTrigger("clap");
            }
            else
            {
                anim.SetTrigger("cheer");
            }
        }
        yield return new WaitForSeconds(1f);

        UIPanel.SetActive(false);
        NPCText.transform.parent.gameObject.SetActive(false);
        PlayerAnim.SetTrigger("change");
        foreach (TextMeshProUGUI t in ButtonText)
        {
            t.transform.parent.GetComponent<Image>().color = Color.white;
        }
        count++;

        yield return new WaitForSeconds(1f);
        image.gameObject.SetActive(false);
        StartCoroutine(UIShow());
    }



    public void Wrong(Image image)
    {
        StartCoroutine(TextAnim(image));
    }

    IEnumerator TextAnim(Image image)
    {
        image.gameObject.SetActive(true);
        WrongText.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        WrongText.SetActive(false);
        image.gameObject.SetActive(false);
    }

    public void Right()
    {
        StartCoroutine(RTextAnim());
    }

    IEnumerator RTextAnim()
    {
        CorrectText.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        CorrectText.SetActive(false);
    }



    public void ChangeColor(Image image)
    {
        image.color = Color.gray;
    }

    public void confettiPlay()
    {
        foreach (ParticleSystem p in confetti)
        {
            p.Play();
        }
    }


}
