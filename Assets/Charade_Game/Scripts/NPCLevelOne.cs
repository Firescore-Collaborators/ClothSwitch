using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NPCLevelOne : MonoBehaviour
{
    public TextMeshProUGUI NPCText;
    public GameObject UIPanel;
    public GameObject UIButtons;
    public Animator NPCANim;
    public Animator DogAnim;
    public Animator CamAnim;
    public Animator[] Cheer;
    public GameObject dogCard;
    public GameObject BananaCard;
    public int count;
    public TextMeshProUGUI[] ButtonsText;

    public GameObject CorrectText;
    public GameObject WrongText;
    public GameObject MakeHimGuess;

    public ParticleSystem[] confetti;

    private void Start()
    {
        count = 1;
        MakeHimGuess.SetActive(true);
        StartCoroutine(UIShow());
    }

    IEnumerator UIShow()
    {
        yield return new WaitForSeconds(1.5f);
        MakeHimGuess.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        NPCANim.SetTrigger("handup");
        yield return new WaitForSeconds(1f);
        UIButtons.SetActive(true);

    }


    public void TextMouse()
    {
        StartCoroutine(Mouse());
       
    }

    IEnumerator Mouse()
    {
        NPCText.transform.parent.gameObject.SetActive(true);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        if (count == 1)
        {
            NPCText.text = "Mouse";
        }
        else
        {
            NPCText.text = "Cucumber";
        }
        Wrong();
    }




    public void  TextCat()
    {
        StartCoroutine(Cat());
    }

    IEnumerator Cat()
    {
        NPCText.transform.parent.gameObject.SetActive(true);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        if (count == 1)
        {
            NPCText.text = "Cat";
        }
        else
        {
            NPCText.text = "Mango";
        }
        Wrong();
    }



    public void TextDog()
    {
        if (count == 1)
        {
            NPCText.text = "Dog";
        }
        else
        {
            NPCText.text = "Pass";
        }
        NPCText.transform.parent.gameObject.SetActive(true);
        StartCoroutine(Change());
        foreach (Animator anim in Cheer)
        {
            if(Random.Range(0,2) == 0)
            {
                anim.SetTrigger("clap");
            }
            else
            {
                anim.SetTrigger("cheer");
            }
        }
        
    }



    public void MimicDog()
    {
        if (count == 1)
        {
            StartCoroutine(DogAnimplay());
        }
        else
        {
            StartCoroutine(Banana());

        }
    }


    IEnumerator Banana()
    {
        NPCText.transform.parent.gameObject.SetActive(true);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);

        NPCText.text = "Banana";
        Right();
        foreach (Animator anim in Cheer)
        {
            confettiPlay();
            if (Random.Range(0, 2) == 0)
            {
                anim.SetTrigger("clap");
            }
            else
            {
                anim.SetTrigger("cheer");
            }
        }
    }


    IEnumerator DogAnimplay()
    {
        yield return new WaitForSeconds(1f);
        UIPanel.SetActive(false);
        UIButtons.SetActive(false);
        yield return new WaitForSeconds(1f);
        CamAnim.SetTrigger("mimic");
        yield return new WaitForSeconds(2f);
        DogAnim.SetTrigger("mimic");
        StartCoroutine(BackCam());
    }

    IEnumerator BackCam()
    {
        
        yield return new WaitForSeconds(5f);
        CamAnim.SetTrigger("mimicend");
        StartCoroutine(Thinking());
    }


    IEnumerator Thinking()
    {
        yield return new WaitForSeconds(1f);
        NPCText.transform.parent.gameObject.SetActive(true);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        StartCoroutine(EndAns());
    }

    IEnumerator EndAns()
    {
        yield return new WaitForSeconds(0.1f);
        Right();
        NPCText.text = "Dog";
        NPCText.transform.parent.gameObject.SetActive(true);
        StartCoroutine(Change());
    }

    IEnumerator Change()
    {
        count++;
        foreach (Animator anim in Cheer)
        {
            confettiPlay();
            if (Random.Range(0, 2) == 0)
            {
                anim.SetTrigger("clap");
            }
            else
            {
                anim.SetTrigger("cheer");
            }
        }
        yield return new WaitForSeconds(2f);
        NPCANim.SetTrigger("change");
        BananaCard.SetActive(true);
        dogCard.SetActive(false);
        NPCText.transform.parent.gameObject.SetActive(false);
        UIButtons.SetActive(false);
        yield return new WaitForSeconds(2f);
        ButtonsText[0].text = "A Yellow Fruit";
        ButtonsText[1].text = "A Curved Fruit";
        ButtonsText[2].text = "Pass";
        ButtonsText[3].text = "You can peel it.";
        UIButtons.SetActive(true);
        foreach(TextMeshProUGUI t in ButtonsText)
        {
            t.transform.parent.GetComponent<Image>().color = Color.white;
        }
    }

    public void ChangeColor(Image image)
    {
        image.color = Color.gray;
    }

    public void Wrong()
    {
        StartCoroutine(TextAnim());
    }

    IEnumerator TextAnim()
    {
        WrongText.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        WrongText.SetActive(false);
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

    public void ThinkingDot()
    {
        StartCoroutine(dot2());
    }

    IEnumerator dot2()
    {
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = ".";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "..";
        yield return new WaitForSeconds(0.2f);
        NPCText.text = "...";
        yield return new WaitForSeconds(0.2f);
    }

    public void confettiPlay()
    {
        foreach(ParticleSystem p in confetti)
        {
            p.Play();
        }
    }

}
