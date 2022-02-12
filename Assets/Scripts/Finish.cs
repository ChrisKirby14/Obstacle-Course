using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Finish : MonoBehaviour
{
    [SerializeField] AudioClip finish;

    AudioSource AS;

    void Start() 
    {
        AS = GetComponent<AudioSource>();
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
        AS.PlayOneShot(finish);
        Debug.Log("You made it to the end");
    }
}
