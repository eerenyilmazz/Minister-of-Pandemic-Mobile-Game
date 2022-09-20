using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject dezenfektan = default;
    public GameObject maske = default;
    public GameObject virus1 = default;
    public GameObject virus2 = default;
    public GameObject virus3 = default;
    public GameObject kolonya = default;
    public GameObject can = default;
    public GameObject mesafeKucuk = default;
    public GameObject mesafeBuyuk = default;
    public GameObject eldivenCift = default;


    void Start()
    {
        InvokeRepeating("ObjeSpawnla", 0, 0.9f);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Siringa")
        {
            Debug.Log("Yok edildi");
        }
    }

    void ObjeSpawnla()
    { 
        Vector2 ekranBoyutu = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Vector2 rastgeleKonumDikey = new Vector2(Random.Range(-ekranBoyutu.x, ekranBoyutu.x), Random.Range(0, 2) == 0 ? -ekranBoyutu.y - 1 : ekranBoyutu.y + 1 );

        Vector2 rastgeleKonumYatay = new Vector2(Random.Range(0, 2) == 0 ? -ekranBoyutu.x - 1 : ekranBoyutu.x + 1, Random.Range(-ekranBoyutu.y, ekranBoyutu.y));

        Vector2 spawnPos = Random.Range(0, 2) == 0 ? rastgeleKonumYatay : rastgeleKonumDikey;

        Instantiate(RastgeleObje(), spawnPos, RastgeleObje().transform.rotation);
    }


    GameObject RastgeleObje()
    {
        float yuzde = Random.Range(0, 140);

        if (yuzde < 11)
            return can;

        else if (yuzde > 10 && yuzde < 30)
            return virus1;

        else if (yuzde > 30 && yuzde < 40)
            return maske;

        else if (yuzde > 40 && yuzde < 60)
            return virus2;

        else if (yuzde > 60 && yuzde < 70)
            return dezenfektan;

        else if (yuzde > 70 && yuzde < 90)
            return virus3;

        else if (yuzde > 90 && yuzde < 100)
            return kolonya;

        else if (yuzde > 100 && yuzde < 120)
            return mesafeKucuk;

        else if (yuzde > 120 && yuzde < 130)
            return mesafeBuyuk;

        else 
            return eldivenCift;

    }

}
