using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 6f;
    [SerializeField] float jump = 1f;
    [SerializeField] AudioClip move;

    AudioSource AS;
    // Start is called before the first frame update
    void Start()
    {
        AS = GetComponent<AudioSource>();
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        MovementSound();
    }

    void MovementSound()
    {
        if(Input.GetKey(KeyCode.A))
        if(Input.GetKey(KeyCode.S))
        if(Input.GetKey(KeyCode.D))
        if(Input.GetKey(KeyCode.W))
        {
            AS.PlayOneShot(move);
        }
    }


    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Use WASD or arrow keys to move");
        Debug.Log("Avoid touching other objects");
        Debug.Log("Make it from the blue square to the red square");

    }



    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * jump;
        transform.Translate(xValue,yValue,zValue);
    }

}
