using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CambioTextosMenu : MonoBehaviour {

   

    //textos MainMenu
    [SerializeField]
    private Text comenzar;
    [SerializeField]
    private Text creditos;
    [SerializeField]
    private Text salir;

    //textos comenzar partida
    [SerializeField]
    private Text crear;
    [SerializeField]
    private Text numjugadores;
    [SerializeField]
    private Text Numrondas;

    //textos opciones
    [SerializeField]
    private Text opciones;

    [SerializeField]
    private Text idioma;
    [SerializeField]
    private Text ingles;
    [SerializeField]
    private Text espanol;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        switch (cambioIdioma.idioma) {

            case true:
            
                comenzar.text = "Comenzar";
                creditos.text = "Creditos";
                salir.text = "Salir";
                crear.text = "Crear Partida";
                numjugadores.text = "# Jugadores           4";
                Numrondas.text = "# Rondas             8";
                opciones.text = "Opciones";
                idioma.text = "Idioma";
                espanol.text = "Español";
                ingles.text = "Ingles";
                break;


            case false:
                
                comenzar.text = "Start";
                creditos.text = "Credits";
                salir.text = "Exit";
                crear.text = "Create match";
                numjugadores.text = "# Players           4";
                Numrondas.text = "# Rounds           8";
                opciones.text = "Options";
                idioma.text = "Language";
                espanol.text = "Spanish";
                ingles.text = "English";
                break;

        }

	}
}
