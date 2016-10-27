using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class cambiosTextosENG : MonoBehaviour {

    private GameMaster gm;
    private string[] respuestas;

    [SerializeField]
    private GameObject fader;
    //puntajes temporales ronda
    private int puntajeP1Temp1;
    private int puntajeP1Temp2;
    private int puntajeP1Temp3;
    private int puntajeP2;
    private int puntajeP3;
    private int puntajeP4;

    //puntajes reales
    private int punt1f;
    private int punt2f;
    private int punt3f;
    private int punt4f;
    private int contadorJugador;

    void Awake()
    {
        respuestas = new string[3];
        contadorJugador = 0;
        puntajeP1Temp1 = 0;
        puntajeP1Temp2 = 0;
        puntajeP1Temp3 = 0;
        puntajeP2 = 0;
        puntajeP3 = 0;
        puntajeP4 = 0;
        punt1f = 0;
        punt2f = 0;
        punt3f = 0;
        punt4f = 0;

    }
    //textos pantalla1 estado Pant1
    [SerializeField]
    private Text Ronda, JugadorDibuja;

    //textos pantalla2 estado Palabra
    [SerializeField]
    private Text pal;
    [SerializeField]
    private Text tupal;

    //textos pantalla3 estado Graf
    [SerializeField]
    private Text palagraf;

    //textos pantalla3 estado Quees
    [SerializeField]
    private Text JugadoresPR, Warning;
    [SerializeField]
    private Text que;
    [SerializeField]
    private InputField inputfield;
    [SerializeField]
    private GameObject inputfi;
    

    //textos pantalla4 estado Resultados1
    [SerializeField]
    private Text R1palabra;
    [SerializeField]
    private Text r1p1;
    [SerializeField]
    private Text r1p2;
    [SerializeField]
    private Text r1p3;

    //textos pantalla resultados totales

    [SerializeField]
    private Text Pjugador1;
    [SerializeField]
    private Text Pjugador2;
    [SerializeField]
    private Text Pjugador3;
    [SerializeField]
    private Text Pjugador4;
    [SerializeField]
    private Text puntajes;

    //texto pantalla Ganador
    [SerializeField]
    private Text ganador;

    [SerializeField]
    private Text TextInputBox;

    [SerializeField]
    private Text pantallaComenzar;

    // Use this for initialization
    void Start()
    {
        gm = gameObject.GetComponent<GameMaster>();
        TextInputBox.text = "Enter Text...";
        pantallaComenzar.text = "Tap To Start";
        tupal.text = "Your word is ";
        que.text = "What is it?";
        puntajes.text = "Scores";

    }

    // Update is called once per frame
    void Update()
    {
        //asignacion puntajes totales siempre seran iguales sin importar el estado del jugador
        
        Pjugador1.text = "Player1   " + punt1f + " Points";
        Pjugador2.text = "Player2   " + punt2f + " Points";
        Pjugador3.text = "Player3   " + punt3f + " Points";
        Pjugador4.text = "Player4   " + punt4f + " Points";

        switch (gm.GetPlayerState())
        {
            case PlayerStates.jugador1:
                //asignacion textos pantalla 1
                Ronda.text = "Round " + gm.NumeroRondas;
                JugadorDibuja.text = "Player 1 Draws";
                //asignacion textos pantalla palabra
                pal.text = gm.Palabra;
                //asignacion textos pantalla
                palagraf.text = gm.Palabra;
                //asignacion textos puntajes1
                R1palabra.text = "The Word Was  " + gm.PalabraOrg;
                r1p1.text = "P2 " + respuestas[0] + "  P2 +" + puntajeP2 + "    P1 +" + puntajeP1Temp1;
                r1p2.text = "P3 " + respuestas[1] + "  P3 +" + puntajeP3 + "    P1 +" + puntajeP1Temp2;
                r1p3.text = "P4 " + respuestas[2] + "  P4 +" + puntajeP4 + "    P1 +" + puntajeP1Temp3;


                break;
            case PlayerStates.jugador2:
                //asignacion textos pantalla 1
                Ronda.text = "Round " + gm.NumeroRondas;
                JugadorDibuja.text = "Player 2 Draws";
                //asignacion textos pantalla palabra
                pal.text = gm.Palabra;
                //asignacion textos pantalla
                palagraf.text = gm.Palabra;
                //asignacion puntajes1
                R1palabra.text = "The Word Was " + gm.PalabraOrg;
                r1p1.text = "P1 " + respuestas[0] + " p1 +" + puntajeP2 + "    P2 +" + puntajeP1Temp1;
                r1p2.text = "P3 " + respuestas[1] + " p3 +" + puntajeP3 + "    P2 +" + puntajeP1Temp2;
                r1p3.text = "P4 " + respuestas[2] + " p4 +" + puntajeP4 + "    P2 +" + puntajeP1Temp3;

                break;
            case PlayerStates.jugador3:
                //asignacion textos pantalla 1
                Ronda.text = "Round " + gm.NumeroRondas;
                JugadorDibuja.text = "Player 3 Draws";
                //asignacion textos pantalla palabra
                pal.text = gm.Palabra;
                //asignacion textos pantalla
                palagraf.text = gm.Palabra;
                //asignacion puntajes1
                R1palabra.text = "The Word Was " + gm.PalabraOrg;
                r1p1.text = "P1 " + respuestas[0] + " p1 +" + puntajeP2 + "    P3 +" + puntajeP1Temp1;
                r1p2.text = "P2 " + respuestas[1] + " p2 +" + puntajeP3 + "    P3 +" + puntajeP1Temp2;
                r1p3.text = "P4 " + respuestas[2] + " p4 +" + puntajeP4 + "    P3 +" + puntajeP1Temp3;

                break;
            case PlayerStates.jugador4:
                //asignacion textos pantalla 1
                Ronda.text = "Round " + gm.NumeroRondas;
                JugadorDibuja.text = "Player 4 Draws";
                //asignacion textos pantalla palabra
                pal.text = gm.Palabra;
                //asignacion textos pantalla
                palagraf.text = gm.Palabra;
                //asignacion puntajes1
                R1palabra.text = "The Word Was " + gm.PalabraOrg;
                r1p1.text = "P1 " + respuestas[0] + " p1 +" + puntajeP2 + "    P4 +" + puntajeP1Temp1;
                r1p2.text = "P2 " + respuestas[1] + " p2 +" + puntajeP3 + "    P4 +" + puntajeP1Temp2;
                r1p3.text = "P3 " + respuestas[2] + " p3 +" + puntajeP4 + "    P4 +" + puntajeP1Temp3;
                break;

        }
    }

    public void textoGraficador()
    {
        switch (gm.GetPlayerState())
        {
            case PlayerStates.jugador1:
                JugadoresPR.text = "Player2";
                break;

            case PlayerStates.jugador2:
                JugadoresPR.text = "Player1";
                break;

            case PlayerStates.jugador3:
                JugadoresPR.text = "Player1";
                break;

            case PlayerStates.jugador4:
                JugadoresPR.text = "Player1";
                break;


        }
    }

    public void Respuestas()
    {
        switch (gm.GetPlayerState())
        {

            case PlayerStates.jugador1:
                controlInputbox("Player3", "Player4");
                break;
            case PlayerStates.jugador2:
                controlInputbox("Player3", "Player4");
                break;
            case PlayerStates.jugador3:
                controlInputbox("Player2", "Player4");
                break;
            case PlayerStates.jugador4:
                controlInputbox("Player2", "Player3");
                break;
        }
    }

    private void controlInputbox(string a, string b)
    {

        if (inputfield.text == "")
        {
            Warning.text = "Field is empty";
            gm.inputcont = gm.inputcont - 1;

        }
        else
        {
            if (contadorJugador == 0 && gm.inputcont <= 3)
            {
                Warning.text = "";
                respuestas[0] = inputfield.text.ToLower();
                contadorJugador++;
                JugadoresPR.text = a;
                if (inputfield.text.ToLower() == gm.PalabraOrg)
                {
                    puntajeP2 += 3;
                    puntajeP1Temp1 += 5;

                }
                inputfield.text = "";

            }
            else if (contadorJugador == 1 && gm.inputcont <= 3)
            {
                Warning.text = "";
                respuestas[1] = inputfield.text.ToLower();
                contadorJugador++;
                JugadoresPR.text = b;
                if (inputfield.text.ToLower() == gm.PalabraOrg)
                {
                    puntajeP3 += 3;
                    puntajeP1Temp2 += 5;

                }
                inputfield.text = "";
            }
            else if (contadorJugador == 2 && gm.inputcont <= 3)
            {
                Warning.text = "";
                respuestas[2] = inputfield.text.ToLower();
                contadorJugador = 0;
                inputfi.SetActive(false);
                if (inputfield.text.ToLower() == gm.PalabraOrg)
                {
                    puntajeP4 += 3;
                    puntajeP1Temp3 += 5;

                }
                JugadoresPR.text = "";
                fader.SetActive(true);
                StartCoroutine(esperarxSegs(2f));        
            }
        }
    }

    public void Sumadorpuntaje()
    {

        switch (gm.GetPlayerState())
        {

            case PlayerStates.jugador1:
                punt1f = punt1f + puntajeP1Temp1 + puntajeP1Temp2 + puntajeP1Temp3;
                punt2f = punt2f + puntajeP2;
                punt3f = punt3f + puntajeP3;
                punt4f = punt4f + puntajeP4;
                puntajeP1Temp1 = 0;
                puntajeP1Temp2 = 0;
                puntajeP1Temp3 = 0;
                puntajeP2 = 0;
                puntajeP3 = 0;
                puntajeP4 = 0;

                break;
            case PlayerStates.jugador2:
                punt1f = punt1f + puntajeP2;
                punt2f = punt2f + puntajeP1Temp1 + puntajeP1Temp2 + puntajeP1Temp3;
                punt3f = punt3f + puntajeP3;
                punt4f = punt4f + puntajeP4;
                puntajeP1Temp1 = 0;
                puntajeP1Temp2 = 0;
                puntajeP1Temp3 = 0;
                puntajeP2 = 0;
                puntajeP3 = 0;
                puntajeP4 = 0;
                break;
            case PlayerStates.jugador3:
                punt1f = punt1f + puntajeP2;
                punt2f = punt2f + puntajeP3;
                punt3f = punt3f + puntajeP1Temp1 + puntajeP1Temp2 + puntajeP1Temp3;
                punt4f = punt4f + puntajeP4;
                puntajeP1Temp1 = 0;
                puntajeP1Temp2 = 0;
                puntajeP1Temp3 = 0;
                puntajeP2 = 0;
                puntajeP3 = 0;
                puntajeP4 = 0;
                break;
            case PlayerStates.jugador4:
                punt1f = punt1f + puntajeP2;
                punt2f = punt2f + puntajeP3;
                punt3f = punt3f + puntajeP4;
                punt4f = punt4f + puntajeP1Temp1 + puntajeP1Temp2 + puntajeP1Temp3;
                puntajeP1Temp1 = 0;
                puntajeP1Temp2 = 0;
                puntajeP1Temp3 = 0;
                puntajeP2 = 0;
                puntajeP3 = 0;
                puntajeP4 = 0;
                break;
        }
        punt1f = punt1f + puntajeP1Temp1 + puntajeP1Temp2 + puntajeP1Temp3;

    }

    public void Ganador()
    {
        if (punt1f > punt2f && punt1f > punt2f & punt1f > punt3f)
        {
            ganador.text = "P1 WINS";
        }
        else if (punt2f > punt1f && punt2f > punt3f && punt2f > punt4f)
        {
            ganador.text = "P2 WINS";

        }
        else if (punt3f > punt1f && punt3f > punt2f && punt3f > punt4f)
        {
            ganador.text = "P3 WINS";
        }
        else if (punt4f > punt1f && punt4f > punt2f && punt4f > punt2f)
        {
            ganador.text = "P4 WINS";
        }
        else
        {
            ganador.text = "THERE WAS A DRAW";
        }

    }
    IEnumerator esperarxSegs(float x)
    {
        yield return new WaitForSeconds(x);
        gm.gamestates = GameStates.resultado1;
        yield return new WaitForSeconds(0.1f);
    }
}
