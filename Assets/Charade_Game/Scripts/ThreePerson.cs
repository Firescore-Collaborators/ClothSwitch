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

                    if (hit.transform.name == "MGirlShoe")
                    {

                        done = true;
                        cloth = hit.transform.name;
                        clothSelected = hit.transform.gameObject;
                        MGirlShoe.SetActive(false);
                        clothSelected = Instantiate(GirlShoe, hit.transform.position, hit.transform.rotation);
                    }

                  
                }
                clothSelected.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(3f, 3f, 3f));
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            print(count);
            done = false;
            clothSelected.gameObject.SetActive(false);

            if(cloth == "MSweater")
            {
                WSweater.SetActive(true);
            }
         
        }
    }
}
