using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorClickSound : MonoBehaviour
{
    void Start()
    {
    
    }
        public AudioSource audioSource; 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        Debug.Log("Cursor-Click");
        audioSource.Play();
        }

            
    }
}
    


