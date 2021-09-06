using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject arrowPrefab;
    public GameObject applePrefab;

    float arrowSpan = 1f;
    float appleSpan = 3f;
    float arrowDelta = 0f;
    float appleDelta = 0f;


    void Update()
    {
        this.appleDelta += Time.deltaTime;
        this.arrowDelta += Time.deltaTime;

        if (this.appleDelta > this.appleSpan)
        {
            this.appleDelta = 0;
            GameObject go = Instantiate(applePrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

        if (this.arrowDelta > this.arrowSpan)
        {
            this.arrowDelta = 0;
            GameObject go = Instantiate(arrowPrefab) as GameObject;
            int px = Random.Range(-6, 7);
            go.transform.position = new Vector3(px, 7, 0);
        }

    }
}
