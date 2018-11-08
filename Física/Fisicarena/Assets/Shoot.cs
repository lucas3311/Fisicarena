using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform Emitter;
    public float Velocidade;
    public Rigidbody2D Bullet;
    public float velBullet;

    public Camera camera;
    public float speed;

    public GameObject GameManager;

    public GameObject Player;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetButton("W"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.right * Velocidade * Time.deltaTime);
        }
        if (Input.GetButton("S"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * Velocidade * Time.deltaTime);
        }
        if (Input.GetButton("D"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * Velocidade * Time.deltaTime);
        }
        if (Input.GetButton("A"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.up * Velocidade * Time.deltaTime);
        }
        if (Input.GetButtonDown("Space")) {
            Rigidbody2D bulletInstance;
            bulletInstance = Instantiate(Bullet, Emitter.position,Emitter.rotation) as Rigidbody2D;
            bulletInstance.AddForce(Emitter.up * velBullet);
        }
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            GameManager.GetComponent<GameManager>().Score2 += 1;
            GameManager.GetComponent<GameManager>().phase += 1;
            Instantiate(Player, new Vector3(-7.64f, 0, -0.01953382f),Quaternion.Euler(new Vector3(0, 0, -90)));
            Destroy(gameObject);

        }
    }
}
