using UnityEngine;
using System.Collections;

public class pruebacamara : MonoBehaviour {

	Tiempo tiempo;

	void Awake(){
		tiempo = GetComponent<Tiempo> ();
	}
	// Use this for initialization
	void Start () {
		prueba ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void prueba(){
		Debug.Log("hola");
		StartCoroutine (tiempo.esperar (3));

	}

}
