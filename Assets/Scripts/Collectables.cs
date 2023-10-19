using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collectables : MonoBehaviour
{
    public int score = 0;

    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
            score++;
            Debug.Log("Score: " + score);
        }
        else if (collision.transform.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
