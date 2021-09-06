using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float move;
    float speed = 20f;

    void Update()
    {
        move = Input.GetAxis("Horizontal");
        transform.Translate(move * speed * Time.deltaTime, 0, 0);
    }

    public void LButtonDown()
    {
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    
    public void RButtonDown()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }


}
