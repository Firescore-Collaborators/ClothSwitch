using System.Collections;
using UnityEngine;
using TMPro;

public class NPCLevelThree : MonoBehaviour
{
    public TMP_InputField PlaceholderText;
    public TMP_InputField InputText;
    public Animator PlayerAnim;

    public void CheckText()
    {
        for(int i = 0; i <= InputText.text.Length - 1; i++)
        {
            if(PlaceholderText.text[i]==InputText.text[i])
            {
                print("ok");
            }
            else
            {
                StartCoroutine(ResetText());
                break;
            }
        }

        if(PlaceholderText.text == InputText.text)
        {
            change();
        }
    }

    IEnumerator ResetText()
    {
        PlaceholderText.textComponent.gameObject.SetActive(false);
        InputText.textComponent.color = Color.red;
        yield return new WaitForSeconds(0.2f);
        InputText.text = "";
        InputText.textComponent.color = Color.green;
        PlaceholderText.textComponent.gameObject.SetActive(true);
    }

    public void change()
    {
        PlayerAnim.SetTrigger("change");
        PlaceholderText.text = "A Fruit, You can peel it";
    }
}
