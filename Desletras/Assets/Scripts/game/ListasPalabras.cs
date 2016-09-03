using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListasPalabras : MonoBehaviour {
	private List<string> listaPalabras;
	private List<string> listaPalabrasorg;

	private int tamaño;
	// Use this for initialization
	void Awake(){
		listaPalabras = new List<string>();
		listaPalabrasorg = new List<string>();

        if (cambioIdioma.idioma == true)
        {
            listaPalabras.Add("bolar");//arbol
            listaPalabras.Add("rlfo");//flor
            listaPalabras.Add("raom");//amor//roma//mora
            listaPalabras.Add("odesd");//dedos
            listaPalabras.Add("lilas");//silla
            listaPalabras.Add("aasc");//casa
            listaPalabras.Add("oracr");//carro
            listaPalabras.Add("ootm");//moto
            listaPalabras.Add("taye");//yate
            listaPalabras.Add("canbo");//banco
            listaPalabras.Add("naar");//rana
            listaPalabras.Add("rorep");//perro
            listaPalabras.Add("oatg");//gato//gota
            listaPalabras.Add("amse");//mesa
            listaPalabras.Add("luiacetop");//eucalipto
            listaPalabras.Add("ovas");//vaso
            listaPalabras.Add("oplta");//plato
            listaPalabras.Add("nanmaza");//manzana
            listaPalabras.Add("raep");//pera
            listaPalabras.Add("ioñn");//niño
            listaPalabras.Add("ñnai");//niña
            listaPalabras.Add("naolb");//balon
            listaPalabras.Add("tlufbo");//futbol
            listaPalabras.Add("nmoa");//mano
            listaPalabras.Add("ispe");//pies
            listaPalabras.Add("azrni");//nariz
            listaPalabras.Add("zcebaa");//cabeza
            listaPalabras.Add("sooj");//ojos
            listaPalabras.Add("nraanaj");//naranja
            listaPalabras.Add("ols");//sol
            listaPalabrasorg.Add("arbol");//arbol
            listaPalabrasorg.Add("flor");//flor
            listaPalabrasorg.Add("amor");//amor//roma//mora
            listaPalabrasorg.Add("dedos");//dedos
            listaPalabrasorg.Add("silla");//silla
            listaPalabrasorg.Add("casa");//casa
            listaPalabrasorg.Add("carro");//carro
            listaPalabrasorg.Add("moto");//moto
            listaPalabrasorg.Add("yate");//yate
            listaPalabrasorg.Add("banco");//banco
            listaPalabrasorg.Add("rana");//rana
            listaPalabrasorg.Add("perro");//perro
            listaPalabrasorg.Add("gato");//gato//gota
            listaPalabrasorg.Add("mesa");//mesa
            listaPalabrasorg.Add("eucalipto");//eucalipto
            listaPalabrasorg.Add("vaso");//vaso
            listaPalabrasorg.Add("plato");//plato
            listaPalabrasorg.Add("manzana");//manzana
            listaPalabrasorg.Add("pera");//pera
            listaPalabrasorg.Add("niño");//niño
            listaPalabrasorg.Add("niña");//niña
            listaPalabrasorg.Add("balon");//balon
            listaPalabrasorg.Add("futbol");//futbol
            listaPalabrasorg.Add("mano");//mano
            listaPalabrasorg.Add("pies");//pies
            listaPalabrasorg.Add("nariz");//nariz
            listaPalabrasorg.Add("cabeza");//cabeza
            listaPalabrasorg.Add("ojos");//ojos
            listaPalabrasorg.Add("naranja");//naranja
            listaPalabrasorg.Add("sol");//sol
            tamaño = listaPalabras.Count;


        }
        else {
            listaPalabras.Add("bolar");//arbol
            listaPalabrasorg.Add("arbol");//arbol

            tamaño = listaPalabras.Count;
        }
		

	}

	void Start () {
		
	    

	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public string palDes(int a){
		return listaPalabras[a];
	}

	public string palOrg(int a){
		return listaPalabrasorg[a];
	}

	public List<string> Lista(){
		return listaPalabras;
	}

	public int Size{
		get {return tamaño;}
	}
}
