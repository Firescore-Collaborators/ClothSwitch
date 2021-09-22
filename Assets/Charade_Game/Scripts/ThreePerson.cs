using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreePerson : MonoBehaviour
{

    public GameObject BCapPant;
    public GameObject BCapSuit;
    public GameObject BGlass;
    public GameObject BCoat;
    public GameObject BHarryPant;
    public GameObject BHarryShoes;
    public GameObject BSweater;
    public GameObject BSkirt;
    public GameObject BGirlShoe;
    public GameObject BGirlSuit;
    public GameObject BUnderWear;
    


    public GameObject WCapPant;
    public GameObject WCapSuit;
    public GameObject WGlass;
    //public GameObject WCoat;
    public GameObject WHarryPant;
    public GameObject WHarryShoes;
    public GameObject WSweater;
    public GameObject WSkirt;
    public GameObject WGirlShoe;
    public GameObject WGirlSuit;
    public GameObject Bra;
    public GameObject WUnderWear;


    public GameObject MCapPant;
    public GameObject MCapSuit;
    public GameObject MGlass;
    public GameObject MCoat;
    public GameObject MHarryPant;
    public GameObject MHarryShoes;
    public GameObject MSweater;
    public GameObject MSkirt;
    public GameObject MGirlShoe;
    public GameObject MGirlSuit;


    public GameObject CapPant;
    public GameObject CapSuit;
    public GameObject Glass;
    public GameObject Coat;
    public GameObject HarryPant;
    public GameObject HarryShoes;
    public GameObject Sweater;
    public GameObject Skirt;
    public GameObject GirlShoe;
    public GameObject GirlSuit;


    public ParticleSystem Maleconfetti;
    public ParticleSystem Femaleconfetti;
    public ParticleSystem Boyconfetti;
    
    public Animator MaleAnimator;
    public Animator FeMaleAnimator;
    public Animator BoyAnimator;


    GameObject clothSelected;
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
                    if (hit.transform.name == "MSweater")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        MSweater.SetActive(false);
                       
                        clothSelected = Instantiate(Sweater, hit.transform.position, hit.transform.rotation);  
                    }

                    if (hit.transform.name == "WHarryShoes")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        WHarryShoes.SetActive(false);
                        clothSelected = Instantiate(HarryShoes, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "BCapPant")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        BUnderWear.SetActive(true);
                        clothSelected = hit.transform.gameObject;
                        BCapPant.SetActive(false);
                        clothSelected = Instantiate(CapPant, hit.transform.position, hit.transform.rotation);
                    }
                    
                    if (hit.transform.name == "MSkirt")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        MSkirt.SetActive(false);
                        MCoat.GetComponent<BoxCollider>().enabled = true;
                        clothSelected = Instantiate(Skirt, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "MGirlShoe")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        MGirlShoe.SetActive(false);
                        clothSelected = Instantiate(GirlShoe, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "BGirlSuit")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        BGirlSuit.SetActive(false);
                        clothSelected = Instantiate(GirlSuit, hit.transform.position, hit.transform.rotation);
                    }



                    if (hit.transform.name == "WHarryPant")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        WHarryPant.SetActive(false);
                        clothSelected = Instantiate(HarryPant, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "WSweater")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        WSweater.SetActive(false);
                        clothSelected = Instantiate(Sweater, hit.transform.position, hit.transform.rotation);
                    }


                    if (hit.transform.name == "WCapPant")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        WHarryPant.SetActive(true);
                        WUnderWear.SetActive(true);
                        WCapPant.SetActive(false);
                        clothSelected = Instantiate(CapPant, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "BSkirt")
                    {
                        done = true;
                        cloth = hit.transform.name;
                        BUnderWear.SetActive(true);
                        BSkirt.SetActive(false);
                        clothSelected = Instantiate(Skirt, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "MCoat")
                    {
                        done = true;
                        cloth = hit.transform.name;
                       
                        MCoat.SetActive(false);
                        clothSelected = Instantiate(Coat, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "MHarryPant")
                    {
                        done = true;
                        cloth = hit.transform.name;

                        MHarryPant.SetActive(false);
                        clothSelected = Instantiate(HarryPant, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "WCapSuit")
                    {
                        done = true;
                        cloth = hit.transform.name;
                       
                        Bra.SetActive(true);
                        WCapSuit.SetActive(false);
                        clothSelected = Instantiate(CapSuit, hit.transform.position, hit.transform.rotation);
                    }


                    if (hit.transform.name == "BCapSuit")
                    {
                        done = true;
                        cloth = hit.transform.name;

                        BCapSuit.SetActive(false);
                        BSweater.SetActive(true);
                        clothSelected = Instantiate(CapSuit, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "MGirlSuit")
                    {
                        done = true;
                        cloth = hit.transform.name;
                       
                        MGirlSuit.SetActive(false);
                        clothSelected = Instantiate(GirlSuit, hit.transform.position, hit.transform.rotation);
                    }

                    if (hit.transform.name == "WGlass")
                    {
                        done = true;
                        cloth = hit.transform.name;

                        WGlass.SetActive(false);
                        clothSelected = Instantiate(Glass, hit.transform.position, hit.transform.rotation);
                    }

                }
                clothSelected.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(3f, 3f, 3f));
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            print(cloth);
            done = false;
            clothSelected.gameObject.SetActive(false);

            if(cloth == "MSweater")
            {
                WSweater.SetActive(true);
            }


            if (cloth == "BCapPant")
            {
                WCapPant.SetActive(true);
                WHarryPant.SetActive(false);
            }

            if (cloth == "WHarryShoes")
            {
                BHarryShoes.SetActive(true);
            }

            if (cloth == "MSkirt")
            {
                BUnderWear.SetActive(false);
                BSkirt.SetActive(true);
            }

            if (cloth == "MGirlShoe")
            {
                WGirlShoe.SetActive(true);
            }

            if (cloth == "WHarryPant")
            {
                MHarryPant.SetActive(true);
            }
             
            if (cloth == "WCapPant")
            {
                MCapPant.SetActive(true);
                MHarryPant.SetActive(false);
                WHarryPant.SetActive(true);
            }

            if (cloth == "BGirlSuit")
            {
                MGirlSuit.SetActive(true);
            }

            if (cloth == "WSweater")
            {
                BSweater.SetActive(true);
            }

            if (cloth == "BSkirt")
            {
                WSkirt.SetActive(true);
            }

            if (cloth == "MCoat")
            {
                BCoat.SetActive(true);
            }

            if (cloth == "MHarryPant")
            {
                BHarryPant.SetActive(true);
                BUnderWear.SetActive(false);
            }

            if (cloth == "WCapSuit")
            {
                BCapSuit.SetActive(true);
                BSweater.SetActive(false);
            }

            if (cloth == "MGirlSuit")
            {
                WGirlSuit.SetActive(true);
                Bra.SetActive(false);
                FeMaleAnimator.SetTrigger("dance");
                Femaleconfetti.Play();
            }

            if (cloth == "WGlass")
            {
                BGlass.SetActive(true);
                BoyAnimator.SetTrigger("dance");
                Boyconfetti.Play();
            }

            if (cloth == "BCapSuit")
            {
                MCapSuit.SetActive(true);

                MaleAnimator.SetTrigger("dance");
                Maleconfetti.Play();
            }

        }
    }

}
