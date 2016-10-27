using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    //menu states
    public enum MenuStates { StratMenu, MainMenu, comenzar, Creditos, Opciones, reglas };
    public MenuStates currentstate;
    private int controlMenuReglas;

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

    [SerializeField]
    private GameObject fade;


    [SerializeField]
    private GameObject reglasAbsolutas;
    [SerializeField]
    private GameObject reglasAbsolutasCanvas;

    [SerializeField]
    private GameObject ReglasENGpadre;
    [SerializeField]
    private GameObject ReglasENG1;
    [SerializeField]
    private GameObject ReglasENG2;
    [SerializeField]
    private GameObject ReglasENG3;
    [SerializeField]
    private GameObject ReglasENG4;
    [SerializeField]
    private GameObject ReglasENG5;
    [SerializeField]
    private GameObject ReglasENG6;


    [SerializeField]
    private GameObject ReglasESPpadre;
    [SerializeField]
    private GameObject ReglasESP1;
    [SerializeField]
    private GameObject ReglasESP2;
    [SerializeField]
    private GameObject ReglasESP3;
    [SerializeField]
    private GameObject ReglasESP4;
    [SerializeField]
    private GameObject ReglasESP5;
    [SerializeField]
    private GameObject ReglasESP6;

    [SerializeField]
    private Text txtReglas;

    [SerializeField]
    private GameObject controladoraudio;




    void Awake(){
        controlMenuReglas = 1;
        tap = GetComponent<AudioSource>();
		currentstate = MenuStates.StratMenu;
        cambioIdioma.idioma = true;
        fade.SetActive(false);
        
	}

	void Update(){
        if (controlMenuReglas < 1)
        {
            controlMenuReglas = 1;
        }

        if (controlMenuReglas > 6)
        {
            controlMenuReglas = 6;
        }
        //revisando casos con un switch
        menuReglas(cambioIdioma.idioma);
		switch(currentstate){
		case MenuStates.StratMenu:
			Startm.SetActive (true);
			Mainm.SetActive (false);
            Comenzar.SetActive (false);
            creditos.SetActive (false);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(false);
            reglasAbsolutas.SetActive(false);
            reglasAbsolutasCanvas.SetActive(false);
            break;
		case MenuStates.MainMenu:
			Startm.SetActive (false);
			Mainm.SetActive (true);
            Comenzar.SetActive (false);
            creditos.SetActive (false);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(false);
            reglasAbsolutas.SetActive(false);
            reglasAbsolutasCanvas.SetActive(false);
            break;
		case MenuStates.comenzar:
			Startm.SetActive (false);
			Mainm.SetActive (false);
            Comenzar.SetActive (true);
            creditos.SetActive (false);
            opciones.SetActive(false);
            casillaArriba.SetActive(true);
            cred.SetActive(false);
            reglasAbsolutas.SetActive(false);
            reglasAbsolutasCanvas.SetActive(false);
            break;

		case MenuStates.Creditos:
			Startm.SetActive (false);
			Mainm.SetActive (false);
            Comenzar.SetActive (false);
            creditos.SetActive (true);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(true);
            reglasAbsolutas.SetActive(false);
            reglasAbsolutasCanvas.SetActive(false);
            break;

        case MenuStates.Opciones:
            Startm.SetActive(false);
            Mainm.SetActive(false);
            Comenzar.SetActive(false);
            creditos.SetActive(false);
            opciones.SetActive(true);
            casillaArriba.SetActive(true);
            cred.SetActive(false);
            reglasAbsolutas.SetActive(false);
            reglasAbsolutasCanvas.SetActive(false);
            break;

        case MenuStates.reglas:
            Startm.SetActive(false);
            Mainm.SetActive(false);
            Comenzar.SetActive(false);
            creditos.SetActive(false);
            opciones.SetActive(false);
            casillaArriba.SetActive(false);
            cred.SetActive(false);
            reglasAbsolutas.SetActive(true);
            reglasAbsolutasCanvas.SetActive(true);
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

    public void OnReglas() {
        tap.Play();
        controlMenuReglas = 0;
        currentstate = MenuStates.reglas;
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
        tap.Play();
        fade.SetActive(true);
        Debug.Log("lo que sea");
        StartCoroutine(ComenzarJuego());
        controladoraudio.SetActive(false);
        
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

    public void OnSiguienteRegla() {
        tap.Play();
        controlMenuReglas =controlMenuReglas+1;

    }

    public void OnAnteriorRegla()
    {
        tap.Play();
        controlMenuReglas = controlMenuReglas - 1;
        
    }

    IEnumerator ComenzarJuego() {
        
        
        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene("MainJuego");
        yield return new WaitForSeconds(0.1f);

    }


    public void menuReglas(bool idioma) {

        if (idioma == false)
        {
            ReglasENGpadre.SetActive(true);
            ReglasESPpadre.SetActive(false);
            switch (controlMenuReglas)
            {
                case 1:
                    txtReglas.text = "1/6";
                    ReglasENG1.SetActive(true);
                    ReglasENG2.SetActive(false);
                    ReglasENG3.SetActive(false);
                    ReglasENG4.SetActive(false);
                    ReglasENG5.SetActive(false);
                    ReglasENG6.SetActive(false);
                    break;

                case 2:
                    txtReglas.text = "2/6";
                    ReglasENG1.SetActive(false);
                    ReglasENG2.SetActive(true);
                    ReglasENG3.SetActive(false);
                    ReglasENG4.SetActive(false);
                    ReglasENG5.SetActive(false);
                    ReglasENG6.SetActive(false);
                    break;
                case 3:
                    txtReglas.text = "3/6";
                    ReglasENG1.SetActive(false);
                    ReglasENG2.SetActive(false);
                    ReglasENG3.SetActive(true);
                    ReglasENG4.SetActive(false);
                    ReglasENG5.SetActive(false);
                    ReglasENG6.SetActive(false);
                    break;

                case 4:
                    txtReglas.text = "4/6";
                    ReglasENG1.SetActive(false);
                    ReglasENG2.SetActive(false);
                    ReglasENG3.SetActive(false);
                    ReglasENG4.SetActive(true);
                    ReglasENG5.SetActive(false);
                    ReglasENG6.SetActive(false);
                    break;

                case 5:
                    txtReglas.text = "5/6";
                    ReglasENG1.SetActive(false);
                    ReglasENG2.SetActive(false);
                    ReglasENG3.SetActive(false);
                    ReglasENG4.SetActive(false);
                    ReglasENG5.SetActive(true);
                    ReglasENG6.SetActive(false);         
                    break;

                case 6:
                    txtReglas.text = "6/6";
                    ReglasENG1.SetActive(false);
                    ReglasENG2.SetActive(false);
                    ReglasENG3.SetActive(false);
                    ReglasENG4.SetActive(false);
                    ReglasENG5.SetActive(false);
                    ReglasENG6.SetActive(true);
                    break;

                default:

                    break;
            }
        }
        else {
            ReglasENGpadre.SetActive(false);
            ReglasESPpadre.SetActive(true);
            switch (controlMenuReglas)
            {
                case 1:
                    txtReglas.text = "1/6";
                    ReglasESP1.SetActive(true);
                    ReglasESP2.SetActive(false);
                    ReglasESP3.SetActive(false);
                    ReglasESP4.SetActive(false);
                    ReglasESP5.SetActive(false);
                    ReglasESP6.SetActive(false);
                    break;

                case 2:
                    txtReglas.text = "2/6";
                    ReglasESP1.SetActive(false);
                    ReglasESP2.SetActive(true);
                    ReglasESP3.SetActive(false);
                    ReglasESP4.SetActive(false);
                    ReglasESP5.SetActive(false);
                    ReglasESP6.SetActive(false);
                    break;
                case 3:
                    txtReglas.text = "3/6";
                    ReglasESP1.SetActive(false);
                    ReglasESP2.SetActive(false);
                    ReglasESP3.SetActive(true);
                    ReglasESP4.SetActive(false);
                    ReglasESP5.SetActive(false);
                    ReglasESP6.SetActive(false);
                    break;

                case 4:
                    txtReglas.text = "4/6";
                    ReglasESP1.SetActive(false);
                    ReglasESP2.SetActive(false);
                    ReglasESP3.SetActive(false);
                    ReglasESP4.SetActive(true);
                    ReglasESP5.SetActive(false);
                    ReglasESP6.SetActive(false);
                    break;

                case 5:
                    txtReglas.text = "5/6";
                    ReglasESP1.SetActive(false);
                    ReglasESP2.SetActive(false);
                    ReglasESP3.SetActive(false);
                    ReglasESP4.SetActive(false);
                    ReglasESP5.SetActive(true);
                    ReglasESP6.SetActive(false);
                    break;

                case 6:
                    txtReglas.text = "6/6";
                    ReglasESP1.SetActive(false);
                    ReglasESP2.SetActive(false);
                    ReglasESP3.SetActive(false);
                    ReglasESP4.SetActive(false);
                    ReglasESP5.SetActive(false);
                    ReglasESP6.SetActive(true);
                    break;

                default:

                    break;
            }

        }
        

    }

}
