using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjeHareket : MonoBehaviour
{
    public Transform target;


    float hiz = 2;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("SaglikBakani").GetComponent<Transform>();

    }

    void Update()
    {
        transform.Rotate(0, 0, 1.75f);
        transform.position = Vector2.MoveTowards(transform.position, target.position, hiz * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "SaglikBakani" || col.gameObject.tag == "Siringa")
        {

            Destroy(gameObject);
        }
    }
}