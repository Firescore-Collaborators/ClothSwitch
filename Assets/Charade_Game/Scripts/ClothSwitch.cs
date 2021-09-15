using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ClothSwitch : MonoBehaviour
{
    public GameObject clothSelected;
    public GameObject pareo;
    public GameObject hat;
    public GameObject Bra;
    public GameObject Fishnet;
    public GameObject shirt;

    public GameObject Mpareo;
    public GameObject MBra;
    public GameObject MFishnet;
    public GameObject Mshirt;
    public GameObject Mshots;


    public GameObject Fpareo;
    public GameObject Fhat;
    public GameObject FBra;
    public GameObject FFishnet;
    public GameObject Fshirt;
    public GameObject Fshots;

    public GameObject Female;

    public GameObject pShirt;
    public GameObject Pshots;
    public GameObject pBra;
    public GameObject pFishnet;

    public Animator MaleAnim;
    public Animator FeMaleAnim;

    public ParticleSystem[] confetti;

    bool done = false;
    RaycastHit hit;
    string cloth = "";
    string character = "";
    int count = 0;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (!done)
                {
                    print(hit.transform.name);
                    if (hit.transform.name == "Pareo")
                    {
                        done = true;
                        cloth = "Pareo";
                        clothSelected = hit.transform.gameObject;
                    }

                    if (hit.transform.name == "Hat")
                    {

                        done = true;
                        cloth = "Hat";
                        clothSelected = hit.transform.gameObject;
                    }

                    if (hit.transform.name == "Bra")
                    {

                        done = true;
                        cloth = "Bra";
                        clothSelected = hit.transform.gameObject;
                    }

                    if (hit.transform.name == "Shirt")
                    {

                        done = true;
                        cloth = "Shirt";
                        clothSelected = hit.transform.gameObject;
                    }

                    if (hit.transform.name == "Fishnet")
                    {

                        done = true;
                        cloth = "Fishnet";
                        clothSelected = hit.transform.gameObject;
                    }

                    if (hit.transform.name == "FShirt")
                    {
                        done = true;
                        cloth = "FShirt";
                        Fshirt.SetActive(false);
                        clothSelected = Instantiate(pShirt, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "Fshots")
                    {
                        done = true;
                        cloth = "Fshots";
                        Fshots.SetActive(false);
                        clothSelected = Instantiate(Pshots, hit.transform.position, hit.transform.rotation);
                    }


                    if (hit.transform.name == "MFishnet")
                    {
                        done = true;
                        cloth = "MFishnet";
                        MFishnet.SetActive(false);
                        clothSelected = Instantiate(pFishnet, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "MBra")
                    {
                        done = true;
                        cloth = "MBra";
                        MBra.SetActive(false);
                        clothSelected = Instantiate(pBra, hit.transform.position, hit.transform.rotation);
                    }
                }
                clothSelected.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(4f, 4f, 4f));
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            print(count);
            done = false;
            clothSelected.gameObject.SetActive(false);
            if (cloth == "Pareo")
            {
                Fpareo.SetActive(true);
                count++;
                FeMaleAnim.SetTrigger("action");
            }

            if (cloth == "Hat")
            {
                Fhat.SetActive(true);
                count++;
               
                FeMaleAnim.SetTrigger("action");
            }
            if (cloth == "Bra" && count == 0)
            {
                MBra.SetActive(true);
                count++;
                MaleAnim.SetTrigger("action");
            }

            if (cloth == "Shirt")
            {
                Mshirt.SetActive(true);
                count++;
                MaleAnim.SetTrigger("action");
            }

            if (cloth == "Fishnet")
            {
                Fishnet.SetActive(true);
                count++;
                FeMaleAnim.SetTrigger("action");
            }

            if (cloth == "FShirt")
            {
                shirt.SetActive(true);
                count++;
            }

            if (cloth == "Fshots")
            {
                Mshots.SetActive(true);
                count++;
                MaleAnim.SetTrigger("action");
            }

            if (cloth == "MFishnet")
            {
                FFishnet.SetActive(true);
                count++;
                FeMaleAnim.SetTrigger("action");
            }

            if (cloth == "MBra")
            {
                FBra.SetActive(true);
                MFishnet.GetComponent<BoxCollider>().enabled = true;
                count++;
            }
        }
    }


    public void Confetti()
    {
        foreach (ParticleSystem p in confetti)
        {
            FeMaleAnim.SetTrigger("dance");
            MaleAnim.SetTrigger("dance");
            p.Play();
        }
    }
}