using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    private float horizontalInput;
    private float verticalInput;
    [Space]
    private float moveSpeed =15f;
    public Transform TargetObject;
    public float Length;

    void Update()
    {
        // Move The Object 

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * verticalInput);


     // To change the color when you are in the range

        if(Vector3.Distance(transform.position, TargetObject.position) > Length)
        {
            this.GetComponent<MeshRenderer>().material.color = Color.blue;
        }else
        {
            this.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
}
