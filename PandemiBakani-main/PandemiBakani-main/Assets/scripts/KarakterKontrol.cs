using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KarakterKontrol : MonoBehaviour
{
    Animator animator;
    public static int puan;

    [SerializeField]
    Text PuanText = default;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        gameObject.tag = "SaglikBakani";
    }
    void Update()
    {

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(transform.position.x - mousePosition.x, transform.position.y - mousePosition.y);

        transform.up = direction;

        PuanText.text = "Puan: " + puan;

      
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ObjeDusman")
        {

            puan -= 10;
        }
        if (col.gameObject.tag == "ObjeDost")
        {

            puan += 10;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("ObjeDusman"))
        {
            animator.SetTrigger("carpma");
        }
    }
}
