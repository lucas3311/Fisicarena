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

    public GameObject GameManager;

    public GameObject Player;

    bool CanDie = false;

    public float tempoInvencivel = 4;

    public float Cooldown = 0.3f;
    float Cool;

    public GameObject Particle;
    public AudioSource audio;
    public AudioSource die;

    // Use this for initialization
    void Start()
    {
        Color tmp = gameObject.GetComponent<SpriteRenderer>().color;

        Player.GetComponent<SpriteRenderer>().color = tmp;
        StartCoroutine(Blinker());
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
        if (Input.GetButtonDown("Enter") && Time.time >= Cool) {
            Rigidbody2D bulletInstance;
            bulletInstance = Instantiate(Bullet, Emitter.position,Emitter.rotation) as Rigidbody2D;
            bulletInstance.AddForce(Emitter.up * velBullet);

            Cool = Time.time + Cooldown;
            Particle.GetComponent<ParticleSystem>().Play();
            audio.Play();

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9 && CanDie == true)
        {

            GameManager.GetComponent<GameManager>().Score1 += 1;
            GameManager.GetComponent<GameManager>().phase += 1;
            Instantiate(Player, new Vector3(7.64f, 0, -0.02f), Quaternion.Euler(new Vector3(0, 0, 90)));
            die.Play();

            Destroy(gameObject);

        }
    }
    IEnumerator Blinker()
    {
        Color tmp = Player.GetComponent<SpriteRenderer>().color;
        Player.GetComponent<SpriteRenderer>().color = tmp;

        yield return new WaitForSeconds(tempoInvencivel/10);
        Player.GetComponent<SpriteRenderer>().color = tmp;
        tmp.a = 255;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;
        tmp.a = 0;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;
        tmp.a = 255f;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;
        tmp.a = 0;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;

        tmp.a = 255f;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;

        tmp.a = 0;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;

        tmp.a = 255f;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;

        tmp.a = 0;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;

        tmp.a = 255f;

        yield return new WaitForSeconds(tempoInvencivel / 10);
        Player.GetComponent<SpriteRenderer>().color = tmp;

        tmp.a = 0;

        CanDie = true;
        StopCoroutine("Blinker");
    }
}
