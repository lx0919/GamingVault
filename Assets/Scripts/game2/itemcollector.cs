using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemcollector : MonoBehaviour
{

    private int cherries = 0;

    [SerializeField] private AudioSource collectSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSoundEffect.Play();
            cherries++;
            Destroy(collision.gameObject);
        }
    }
}