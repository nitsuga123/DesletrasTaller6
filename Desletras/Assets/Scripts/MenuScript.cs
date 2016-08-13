using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	//menu states
	public enum MenuStates{StratMenu,MainMenu,CrearServidor,BuscarServidor};
	public MenuStates currentstate;

	[SerializeField]
	private GameObject Startm;

	[SerializeField]
	private GameObject Mainm;

	[SerializeField]
	private GameObject CrearServm;

	[SerializeField]
	private GameObject BuscServ;

	void Awake(){
		currentstate = MenuStates.StratMenu;
	}

	void Update(){
		//revisando casos con un switch
		switch(currentstate){
		case MenuStates.StratMenu:
			Startm.SetActive (true);
			Mainm.SetActive (false);
			CrearServm.SetActive (false);
			BuscServ.SetActive (false);


			break;
		case MenuStates.MainMenu:
			Startm.SetActive (false);
			Mainm.SetActive (true);
			CrearServm.SetActive (false);
			BuscServ.SetActive (false);
			break;
		case MenuStates.CrearServidor:
			Startm.SetActive (false);
			Mainm.SetActive (false);
			CrearServm.SetActive (true);
			BuscServ.SetActive (false);
			break;

		case MenuStates.BuscarServidor:
			Startm.SetActive (false);
			Mainm.SetActive (false);
			CrearServm.SetActive (false);
			BuscServ.SetActive (true);
			break;

		}

	}

	public void OnStart(){
		currentstate = MenuStates.MainMenu; 
	}

	public void OnCrearServidor(){
		currentstate = MenuStates.CrearServidor;
	}

	public void OnBuscarServidor(){
		currentstate = MenuStates.BuscarServidor;
	}

	public void OnCreditos(){
		//no hay interfaz de creditos todavia
	}

	public void OnCrear(){
		
	}
	public void OnBuscar(){

	}

	public void OnAtras(){
		currentstate = MenuStates.MainMenu;
	}
}
