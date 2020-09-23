using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{

    public GameObject Oleek1, Oleek2, Oleek3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log("You selected the " + hit.transform.name);
                
                if (hit.collider.name == "button1")
                {
                    Oleek1.SetActive(true);
                    Oleek2.SetActive(false);
                    Oleek3.SetActive(false);
                }
                if (hit.collider.name == "button2")
                {
                    Oleek1.SetActive(false);
                    Oleek2.SetActive(true);
                    Oleek3.SetActive(false);
                }
                if (hit.collider.name == "button3")
                {
                    Oleek1.SetActive(false);
                    Oleek2.SetActive(false);
                    Oleek3.SetActive(true);
                }
            }
        }
    }
}
