using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothSwitch : MonoBehaviour
{
    public GameObject clothSelected;
    public GameObject pareo;
    public GameObject hat;
    public GameObject shirt;
    RaycastHit hit;
    string cloth = "";
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.name == "Pareo")
                {
                    cloth = "Pareo";
                    clothSelected = hit.transform.gameObject;
                }

                if (hit.transform.name == "Hat")
                {
                    cloth = "Hat";
                    clothSelected = hit.transform.gameObject; 
                }

                if (hit.transform.name == "Shirt")
                {
                    cloth = "Shirt";
                    clothSelected = hit.transform.gameObject;
                }
                clothSelected.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(4f, 4f, 4f));
            }
        }

        if(Input.GetMouseButtonUp(0))
        {
            clothSelected.SetActive(false);
            if(cloth == "Pareo")
            {
                pareo.SetActive(true);
            }

            if(cloth == "Hat")
            {
                hat.SetActive(true);
            }

            if (cloth == "Shirt")
            {
                shirt.SetActive(true);
            }
        }
    }
}