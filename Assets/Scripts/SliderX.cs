using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderX : MonoBehaviour
{
    [SerializeField] float positionX = 3f;
    [SerializeField] float slideSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * slideSpeed, positionX), transform.position.y, transform.position.z );
    }
}
