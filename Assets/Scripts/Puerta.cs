using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public GameObject llaveparaagarrar;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider Col)
    {
        if (!llaveparaagarrar.activeInHierarchy)
        {
            UI.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                UI.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
