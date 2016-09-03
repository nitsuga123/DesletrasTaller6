using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MenuScript : MonoBehaviour {

    //menu states
    public enum MenuStates { StratMenu, MainMenu, comenzar, Creditos, Opciones };
    public MenuStates currentstate;
    
    private AudioSource tap;
	[SerializeField]
	private GameObject Startm;

	[SerializeField]
	private GameObject Mainm;

	[SerializeField]
	private GameObject Comenzar;

	[SerializeField]
	private GameObject creditos;

    [SerializeField]
    private GameObject opciones;

    [SerializeField]
    private GameObject casillaArriba;

    [SerializeField]
    private GameObject cred;
    
    void Awake(){
        tap = GetComponent<AudioSource>();
		currentstate = MenuStates.StratMenu;
        cambioIdioma.idioma = true;
	}

	void Update(){
		//revisando casos con un switch
		switch(currentstate){
		case MenuStates.StratMenu:
			Startm.SetActive (true);
			Mainm.SetActive (false);
            Comenzar.SetActive (false);
            creditos.SetActive (false);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(false);
            break;
		case MenuStates.MainMenu:
			Startm.SetActive (false);
			Mainm.SetActive (true);
            Comenzar.SetActive (false);
            creditos.SetActive (false);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(false);
            break;
		case MenuStates.comenzar:
			Startm.SetActive (false);
			Mainm.SetActive (false);
            Comenzar.SetActive (true);
            creditos.SetActive (false);
            opciones.SetActive(false);
            casillaArriba.SetActive(true);
            cred.SetActive(false);
            break;

		case MenuStates.Creditos:
			Startm.SetActive (false);
			Mainm.SetActive (false);
            Comenzar.SetActive (false);
            creditos.SetActive (true);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(true);
            break;

        case MenuStates.Opciones:
            Startm.SetActive(false);
            Mainm.SetActive(false);
            Comenzar.SetActive(false);
            creditos.SetActive(false);
            opciones.SetActive(true);
            casillaArriba.SetActive(true);
            cred.SetActive(false);
            break;

        }

	}

	public void OnStart(){
        tap.Play();
		currentstate = MenuStates.MainMenu; 
	}

	public void OnComenzar(){
        tap.Play();
        currentstate = MenuStates.comenzar;
	}

	public void OnCreditos(){
        tap.Play();
        currentstate = MenuStates.Creditos;
    }


	public void OnAtras(){
        tap.Play();
        currentstate = MenuStates.MainMenu;
	}

    public void OnSalir()
    {
        tap.Play();
        Application.Quit();
    }

    public void OnOpciones()
    {
        tap.Play();
        currentstate = MenuStates.Opciones;
    }

    public void OnEmpezarPartida()
    {
        SceneManager.LoadScene("MainJuego");
    }

    public void OncambiarIngles() {
        tap.Play();
        cambioIdioma.idioma = false;
    }
    public void OncambiarEspañol()
    {
        tap.Play();
        cambioIdioma.idioma = true;
    }

}
