using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class SiringaHareket : MonoBehaviour
{
    public Vector2 Vec;

    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = -1 * GameObject.Find("SaglikBakani").transform.up * 10;
        gameObject.tag = "Siringa";
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ObjeDusman")
        {
            KarakterKontrol.puan += 10;
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "ObjeDost")
        {
            KarakterKontrol.puan -= 10;
            Destroy(gameObject);
        }
    }
}

	
  