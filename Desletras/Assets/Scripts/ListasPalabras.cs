using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListasPalabras : MonoBehaviour {
	public List<string> listaPalabras;

	// Use this for initialization
	void Start () {
		List<string> listaPalabras = new List<string>();
		listaPalabras.Add ("bolar");//arbol
		listaPalabras.Add ("rlfo");//flor
		listaPalabras.Add   ("raom");//amor//roma//mora
		listaPalabras.Add  ("odesd");//dedos
		listaPalabras.Add   ("lilas");//silla
		listaPalabras.Add   ("aasc");//casa
		listaPalabras.Add  ("oracr");//carro
		listaPalabras.Add   ("ootm");//moto
		listaPalabras.Add   ("taye");//yate
		listaPalabras.Add   ("canbo");//banco
		listaPalabras.Add   ("naar");//rana
		listaPalabras.Add   ("rorep");//perro
		listaPalabras.Add  ("oatg");//gato//gota
		listaPalabras.Add   ("amse");//mesa
		listaPalabras.Add   ("luiacetop");//eucalipto
		listaPalabras.Add   ("ovas");//vaso
		listaPalabras.Add   ("oplta");//plato
		listaPalabras.Add   ("nanmaza");//manzana
		listaPalabras.Add   ("raep");//pera
		listaPalabras.Add   ("ioñn");//niño
		listaPalabras.Add   ("ñnai");//niña
		listaPalabras.Add   ("naolb");//balon
		listaPalabras.Add   ("tlufbo");//futbol
		listaPalabras.Add   ("nmoa");//mano
		listaPalabras.Add   ("ispe");//pies
		listaPalabras.Add   ("azrni");//nariz
		listaPalabras.Add   ("zcebaa");//cabeza
		listaPalabras.Add   ("sooj");//ojos
		listaPalabras.Add   ("nraanaj");//naranja
		listaPalabras.Add   ("ols");//sol
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	/*
	void SetPalabras(string Dificultad){
		if(Dificultad="Facil"){


		}else if(Dificultad="Medio"){
		
		}else{
		
		}
	}
	*/

	public List<string> GetPalabras(){

		return listaPalabras;
	}


}
