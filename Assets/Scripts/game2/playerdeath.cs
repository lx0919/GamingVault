using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerdeath : MonoBehaviour
{

    Rigidbody2D rb;
    private Animator anim;

    //
    Vector3 respawnPoint;
    //SpriteRenderer spriteRenderer;
    //

    [SerializeField] private AudioSource deathSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        //
        respawnPoint = transform.position;
        //
    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            Die();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "fallDetector")
        {
            Die();
        }

        if (collision.tag == "checkpoint")
        {
            respawnPoint = transform.position;
        }
    }


    private void Die()
    {
        deathSoundEffect.Play();
        //rb.bodyType = RigidbodyType2D.Static;
        //anim.SetTrigger("death");
        StartCoroutine(Restart(0.7f));
    }

    IEnumerator Restart(float duration)
    {
        rb.simulated = false;
        yield return new WaitForSeconds(duration);
        transform.position = respawnPoint;
        rb.simulated = true;

        //anim.ResetTrigger("death");
        //rb.bodyType = RigidbodyType2D.Dynamic;
    }

}