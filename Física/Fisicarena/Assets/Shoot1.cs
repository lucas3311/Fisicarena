using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot1 : MonoBehaviour
{
    public Transform Emitter;
    public float Velocidade;
    public Rigidbody2D Bullet;
    public float velBullet;

    public Camera camera;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("Up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * Velocidade * Time.deltaTime);
        }
        if (Input.GetButton("Down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * Velocidade * Time.deltaTime);
        }
        if (Input.GetButton("Right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.up * Velocidade * Time.deltaTime);
        }
        if (Input.GetButton("Left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * Velocidade * Time.deltaTime);
        }
        if (Input.GetButtonDown("Enter")) {
            Rigidbody2D bulletInstance;
            bulletInstance = Instantiate(Bullet, Emitter.position,Emitter.rotation) as Rigidbody2D;
            bulletInstance.AddForce(Emitter.up * velBullet);
        }
        
    }
}
