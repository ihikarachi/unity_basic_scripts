using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iHi_Movement : MonoBehaviour
{
    private Rigidbody rg;
    public float speed = 10.0F;
    public float jumpspeed = 10.0F;

    public float yaw = 0.0f;
    public float pitch = 0.0f;
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    void Start () {
        //Cursor.lockState = CursorLockMode.Locked;
        rg = GetComponent <Rigidbody> ();
    }
   
   
    void Update () {

        yaw += speedH * Input.GetAxis("Mouse X");
        //pitch += speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);


        float translation = Input.GetAxis ("Vertical") * speed;
        float straffe = Input.GetAxis ("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
       
        transform.Translate (straffe, 0, translation);
       
        if (Input.GetKey (KeyCode.Space)) {
            Vector3 atas = new Vector3 (0,10,0);
            rg.AddForce(atas * speed);
        }
       
        if (Input.GetKeyDown ("escape"))
            Cursor.lockState = CursorLockMode.None;

        
    }
    
}
