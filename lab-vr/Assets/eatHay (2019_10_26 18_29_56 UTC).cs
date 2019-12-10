using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eatHay : MonoBehaviour
{
public Image customPanel;
public Image defaultPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter(Collider other) 
    {
     if (other.gameObject.CompareTag("eat"));
         {
            Debug.Log("Compared tag");
            defaultPanel.enabled = false;
            Debug.Log("Default off");
            customPanel.enabled = true;
            Debug.Log("Win on");

            }
    }

}
