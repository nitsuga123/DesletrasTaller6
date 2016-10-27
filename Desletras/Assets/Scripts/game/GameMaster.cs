using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public enum PlayerStates{jugador1,jugador2,jugador3,jugador4};
public enum GameStates{PGame,Pant1,Palabra,Graf,Quees,resultado1,ResultadoFinal,Ganador,credit};

//[RequireComponent(typeof(cambioTextos))]
public class GameMaster : MonoBehaviour {


	public GameStates currentstate;
	public PlayerStates playerstate;

	private cambioTextos cambioText;
    private cambiosTextosENG cambioTextEng;
	private ListasPalabras listP;
    private AudioSource tap;

    private List<string> Lpalabras;
	private string palabraDes;
	private string palabraOrg;
	private float timer;
	private int InputCont;
	private int numeroTurnos;
	private int numeroRonda;
	private int controldeCoroutina;

	private int rand;

	public static int contadorJugador;
	private string[] respuestas;
	private bool IsRunning;

    private ScribblePhysicsMainScript scribleScript;

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
	private GameObject Resultadosf;

	[SerializeField]
	private GameObject pantallaGanador;

    [SerializeField]
    private GameObject pantallaArriba;

    [SerializeField]
    private GameObject pantcreditos;

    [SerializeField]
    private GameObject creditos;

    [SerializeField]
	private Text countdown;

	[SerializeField]
	private InputField inputfield;
	[SerializeField]
	private GameObject inputfi;

    [SerializeField]
    private GameObject fondo;
    [SerializeField]
    private GameObject fondoHueco;
    [SerializeField]
    private GameObject fondoHuecoIz;


    [SerializeField]
    private GameObject fader;
    void Awake(){
        //cambioIdioma.idioma = true;
        fader.SetActive(false);
        tap = GetComponent<AudioSource>();
        cambioText = gameObject.GetComponent<cambioTextos> ();
        cambioTextEng = gameObject.GetComponent<cambiosTextosENG>();
		listP = gameObject.GetComponent<ListasPalabras>();
		IsRunning = false;
		InputCont = 0;
		palabraDes="aacs";
		respuestas = new string[3];
		contadorJugador = 0;
		numeroTurnos = 8;
		numeroRonda = 1;
		controldeCoroutina = 0;
		rand = 0;
 

	}

	void Start(){
		currentstate = GameStates.PGame;
		timer = 60f;  
		rand = Random.Range (0, listP.Size-2);
		palabraDes = listP.palDes (rand);
		palabraOrg = listP.palOrg (rand);
	}

	void Update(){
        MoverDibujoz();
		switch (currentstate) {

		case GameStates.PGame:
			
			PreGame.SetActive (true);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(false);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(false);

			break;
		case GameStates.Pant1:
			PreGame.SetActive (false);
			Pantalla1.SetActive (true);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(false);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(false);
            break;
		case GameStates.Palabra:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (true);
			Graficador.SetActive (false);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(true);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(false);
            break;
		case GameStates.Graf:
			timer -= Time.deltaTime;
			if (timer < 9.5) {
				countdown.text = "0:0" + timer.ToString ("f0");
			} else {
				countdown.text = "0:" + timer.ToString ("f0");
			}
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (true);
			QueS.SetActive(false);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(true);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(false);
            fondoHueco.SetActive(true);
            fondoHuecoIz.SetActive(false);
            break;

		case GameStates.Quees:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive(true);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(true);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(true);
            break;

		case GameStates.resultado1:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive (false);
			Resultados1.SetActive (true);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(true);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(true);
            break;

		case GameStates.ResultadoFinal:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive (false);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (true);
			pantallaGanador.SetActive (false);
            pantallaArriba.SetActive(true);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(false);
            break;

		case GameStates.Ganador:
			PreGame.SetActive (false);
			Pantalla1.SetActive (false);
			MostPalabra.SetActive (false);
			Graficador.SetActive (false);
			QueS.SetActive (false);
			Resultados1.SetActive (false);
			Resultadosf.SetActive (false);
			pantallaGanador.SetActive (true);
            pantallaArriba.SetActive(false);
            creditos.SetActive(false);
            pantcreditos.SetActive(false);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(false);
            break;

        case GameStates.credit:
            PreGame.SetActive(false);
            Pantalla1.SetActive(false);
            MostPalabra.SetActive(false);
            Graficador.SetActive(false);
            QueS.SetActive(false);
            Resultados1.SetActive(false);
            Resultadosf.SetActive(false);
            pantallaGanador.SetActive(false);
            pantallaArriba.SetActive(false);
            creditos.SetActive(true);
            pantcreditos.SetActive(true);
            fondo.SetActive(true);
            fondoHueco.SetActive(false);
            fondoHuecoIz.SetActive(false);
            break;

        }
	}



	 IEnumerator Turnos(){


		//Lpalabras = listP.GetPalabras ();

		//palabra = Lpalabras[0/*Random.Range(0,Lpalabras.Count-1)*/];

		Debug.Log (palabraDes);
		yield return new WaitForSeconds (0.1f);
		controldeCoroutina=controldeCoroutina+1;
		yield return new WaitForSeconds (0.1f);

		if (controldeCoroutina == 1) {
			currentstate = GameStates.Pant1;
			yield return new WaitForSeconds (3.5f);
			currentstate = GameStates.Palabra;
			yield return new WaitForSeconds (5f);
            fader.SetActive(true);
            yield return new WaitForSeconds(2.3f);
            currentstate = GameStates.Graf;
            yield return new WaitForSeconds (60f);
			cambioText.textoGraficador ();
			currentstate = GameStates.Quees;
			MoverDibujo ();
			Debug.Log ("couroutine not stoped");
			controldeCoroutina = 0;
            fader.SetActive(false);
        } else {
			controldeCoroutina = 0;
			yield return new WaitForSeconds (0.1f);
		}

	}

	// botones en orden de pantalla

	//pantallaprincipal
	public void OnPrimerapant(){
        tap.Play();
        currentstate = GameStates.Pant1;
		StartCoroutine (Turnos ());
	}

	//acabardibujo y seguir pantalla
	public void OnTerminado(){
        tap.Play();
        fader.SetActive(false);
        StopAllCoroutines();
		controldeCoroutina = 0;

        if (cambioIdioma.idioma == true)
        {
            cambioText.textoGraficador();
        }
        else {
            cambioTextEng.textoGraficador();
        }
		
		currentstate = GameStates.Quees;
		MoverDibujo ();

	}
	//inputbox control
	public void OnListo(){
		InputCont++;
        tap.Play();
        if (cambioIdioma.idioma == true)
        {
            cambioText.Respuestas();
        }
        else {
            cambioTextEng.Respuestas();

        }
		//revisar antes de eliminar
		//Respuestas ();
	}
	public void OnPasarPuntaje(){
        tap.Play();
        if (cambioIdioma.idioma == true)
        {
            cambioText.Sumadorpuntaje();
        }
        else {
            cambioTextEng.Sumadorpuntaje();
        }
		BorrarDibujo ();
		currentstate = GameStates.ResultadoFinal;
	}

	public void OnSiguienteRonda(){
        fader.SetActive(false);
        tap.Play();
        currentstate = GameStates.Pant1;
		timer = 60f;
		inputfi.SetActive(true);
		inputfield.text = "";
		InputCont = 0;
		cambiadorJugador ();
		if (numeroRonda <= numeroTurnos) {
			rand = Random.Range (0, listP.Size-1);
			palabraDes = listP.palDes (rand);
			palabraOrg = listP.palOrg (rand);
            StartCoroutine(Turnos());


        } else {
            if (cambioIdioma.idioma == true)
            {
                cambioText.Ganador();
            }
            else {
                cambioTextEng.Ganador();
            }
            
            currentstate = GameStates.Ganador;

        }

	}

    public void OnAcreditos() {
        tap.Play();
        currentstate = GameStates.credit;
    }

    public void OnReiniciarJuego() {
        tap.Play();
        fader.SetActive(true);
        StartCoroutine(RegresarMenu());
        
    }



    void cambiadorJugador(){
		numeroRonda = numeroRonda + 1;
		if (playerstate == PlayerStates.jugador1) {
			playerstate = PlayerStates.jugador2;
		} else if (playerstate == PlayerStates.jugador2) {
			playerstate = PlayerStates.jugador3;
		} else if (playerstate == PlayerStates.jugador3) {
			playerstate = PlayerStates.jugador4;
		} else {
			playerstate = PlayerStates.jugador1;
		}
	}
	void BorrarDibujo(){
		GameObject[] allGameObjectsList = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject aGameObject in allGameObjectsList) 
		{
			if (aGameObject.name == "StaticScribble") Destroy(aGameObject);
			if (aGameObject.name == "DynamicScribble") Destroy(aGameObject);
		}

	}

	void MoverDibujo(){
		GameObject[] allGameObjectsList = FindObjectsOfType(typeof(GameObject)) as GameObject[];
		foreach (GameObject aGameObject in allGameObjectsList) 
		{

			if (aGameObject.name == "StaticScribble")aGameObject.transform.position = new Vector3 (aGameObject.transform.position.x - 4.0f, aGameObject.transform.position.y, aGameObject.transform.position.z); //Destroy(aGameObject);
			//if (aGameObject.name == "DynamicScribble") Destroy(aGameObject);
		}
	}

    void MoverDibujoz()
    {
        GameObject[] allGameObjectsList = FindObjectsOfType(typeof(GameObject)) as GameObject[];
        foreach (GameObject aGameObject in allGameObjectsList)
        {

            if (aGameObject.name == "StaticScribble") aGameObject.transform.position = new Vector3(aGameObject.transform.position.x , aGameObject.transform.position.y,120f); //Destroy(aGameObject);
                                                                                                                                                                                                                 //if (aGameObject.name == "DynamicScribble") Destroy(aGameObject);
        }
    }

    public PlayerStates GetPlayerState(){
		return playerstate;
	}
    public GameStates GetgameState()
    {
        return currentstate;
    }

    public GameStates gamestates{
		get {return currentstate;}
		set{currentstate = value;}

	}
	public int NumeroRondas{
		get {return numeroRonda;}
		set{numeroRonda = value;}
	}
	public string Palabra{
		get {return palabraDes;}
		set{palabraDes = value;}
	}

	public string PalabraOrg{
		get {return palabraOrg;}
		set{palabraOrg = value;}
	}

	public int inputcont{
		get {return InputCont;}
		set{InputCont = value;}
	}




    IEnumerator RegresarMenu() {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Menu");
        yield return new WaitForSeconds(0.1f);
    }
   
}
