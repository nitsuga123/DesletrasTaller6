using UnityEngine;
using System.Collections;

public class Tiempo : MonoBehaviour {


	public IEnumerator esperar(float tiempo){
		yield return new WaitForSeconds (tiempo);
		//Debug.Log ("hola3");
	}
}
