using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiringaAtma : MonoBehaviour 
{
	public GameObject Siringa;
	void Update()
	{

		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			Vector2 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			GameObject EdilenSiringa = Instantiate(Siringa, transform.Find("SiringaYer"));
			EdilenSiringa.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles - new Vector3(0,0,225));
			EdilenSiringa.GetComponent<SiringaHareket>().Vec = vec;

		}
	}
}


