using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour {

	public enum GameStates{PGame,Pant1,Palabra,Graf,Quees,resultado1};
	public GameStates currentstate;
	private List<string> Lpalabras;
	private string palabra;
	ListasPalabras listP;
	private float timer;
	public int InputCont;
	private int puntajeP1;
	private int puntajeP2;
	private int puntajeP3;
	private int puntajeP4;



	private int contadorJugador;
	public string[] respuestas;

	[SerializeField]
	private Text text;

	[SerializeField]
	private Text t2;

	[SerializeField]
	private Text countdown;


	[SerializeField]
	private GameObject PreGame;

	[SerializeField]
	private GameObject Pantalla1;

	[SerializeField]
	private GameObject MostPalabra;

	[SerializeField]
	private GameObject Graficador;

	[SerializeField]
	private GameObject QueS;

	[SerializeField]
	private GameObject Resultados1;

	[SerializeField]
	private InputField inputfield;
	[SerializeField]
	private GameObject inputfi;
	[SerializeField]
	private Text Warning;

	[SerializeField]
	private Text JugadoresPR;

	[SerializeField]
	private Text R1palabra;
	[SerializeField]
	private Text r1p1;
	[SerializeField]
	private Text r1p2;
	[SerializeField]
	private Text r1p3;



	void Awake(){
		
		listP = GetComponent<ListasPalabras>();
		InputCont = 0;
		palabra="aacs";
		respuestas = new string[3];
		contadorJugador = 0;
		puntajeP1 = 0;
		puntajeP2 = 0;
		puntajeP3 = 0;
		puntajeP4 = 0;
	}

	void Start(){
		currentstate = GameStates.PGame;

		timer = 60f;
		StartCoroutine (Turnos());

	}

	void Update(){
		
		switch (currentstate) {
		     
		case GameStates.PGame:
			PreGame.SetActive (true);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			break;
		case GameStates.Pant1:
			PreGame.SetActive (false);
			Pantalla1.SetActive (true);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			break;
		case GameStates.Palabra:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (true);
			Graficador.SetActive (false);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			break;
		case GameStates.Graf:
			timer -= Time.deltaTime;
			countdown.text = "0:"+ timer.ToString ("f0");
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (true);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			break;

		case GameStates.Quees:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive(true);
			Resultados1.SetActive (false);

			break;

		case GameStates.resultado1:
			R1palabra.text="La palabra era Casa" ;
			r1p1.text="P2 " + respuestas[0] + " p2 +"+ puntajeP2 + "    P1 +"+puntajeP1;
			r1p2.text="P3 " + respuestas[1] + " p3 +"+ puntajeP3 + "    P1 +"+puntajeP1;
			r1p3.text="P4 " + respuestas[2] + " p4 +"+ puntajeP4 + "    P1 +"+puntajeP1;
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive (false);
			Resultados1.SetActive (true);
			break;
		}
	}



	IEnumerator Turnos(){

		//Lpalabras = listP.GetPalabras ();

		//palabra = Lpalabras[0/*Random.Range(0,Lpalabras.Count-1)*/];

		Debug.Log (palabra);
		text.text = palabra;
		yield return new WaitForSeconds (5);
		currentstate = GameStates.Pant1;
		yield return new WaitForSeconds (5);
		currentstate = GameStates.Palabra;
		yield return new WaitForSeconds (5);
		currentstate = GameStates.Graf;
		t2.text = palabra;
		yield return new WaitForSeconds (60);
		Debug.Log("couroutine not stoped");
		currentstate = GameStates.Quees;

	}

	public void OnTerminado(){
		StopCoroutine (Turnos ());
		currentstate = GameStates.Quees;
		GameObject[] allGameObjectsList = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject aGameObject in allGameObjectsList) 
		{
			
			if (aGameObject.name == "StaticScribble")aGameObject.transform.position = new Vector3 (aGameObject.transform.position.x - 3.0f, aGameObject.transform.position.y, aGameObject.transform.position.z); //Destroy(aGameObject);
			//if (aGameObject.name == "DynamicScribble") Destroy(aGameObject);
		}

	}


	public void OnListo(){
		InputCont++;
		Respuestas ();
	}

	void Respuestas(){
		if (inputfield.text == "") {
			Warning.text="No se ha escrito nada";
			InputCont--;

		} else {
			if (contadorJugador == 0 && InputCont <= 3) {
				Warning.text = "";
				respuestas [0] = inputfield.text;
				contadorJugador++;
				JugadoresPR.text = "Jugador3";
				if (inputfield.text == "casa" || inputfield.text == "Casa") {
					puntajeP2 += 3;
					puntajeP1 += 5;
				}
				inputfield.text = "";

			} else if (contadorJugador == 1 && InputCont <= 3) {
				Warning.text = "";
				respuestas [1] = inputfield.text;
				contadorJugador++;
				JugadoresPR.text = "Jugador4";
				if (inputfield.text == "casa" || inputfield.text == "Casa") {
					puntajeP3 += 3;
					puntajeP1 += 5;
				}
				inputfield.text = "";
			} else if (contadorJugador == 2 && InputCont <= 3) {
				Warning.text = "";
				respuestas [2] = inputfield.text;
				contadorJugador = 0;
				inputfi.SetActive(false);
				if (inputfield.text == "casa" || inputfield.text == "Casa") {
					puntajeP4 += 3;
					puntajeP1 += 5;
				}
				JugadoresPR.text = "";
			} else {
				currentstate = GameStates.resultado1;
			}
		}

	}



}
