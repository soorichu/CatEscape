using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().AddHp(-0.1f);

            Destroy(gameObject);
        }
    }
}
