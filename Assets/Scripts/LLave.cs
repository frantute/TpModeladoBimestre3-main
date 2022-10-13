using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLave : MonoBehaviour
{
    [SerializeField] GameObject UI;
    [SerializeField] GameObject Llaveparaagarrar;
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
        UI.SetActive(true);
        
    }

    void OnTriggerStay(Collider col)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Llaveparaagarrar.SetActive(false);
        }
    }
    void OnTriggerExit(Collider Col)
    {
        UI.SetActive(false);
    }
}
