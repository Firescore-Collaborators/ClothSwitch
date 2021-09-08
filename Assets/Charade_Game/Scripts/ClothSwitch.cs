using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothSwitch : MonoBehaviour
{
    public GameObject pareo;

    RaycastHit hit;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.transform.name == "Pareo")
                {
                    hit.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(5f, 5f, 5f));
                }
            }
           
        }

        if(Input.GetMouseButtonUp(0))
        {
            hit.transform.gameObject.SetActive(false);
            pareo.SetActive(true);
        }
    }
}