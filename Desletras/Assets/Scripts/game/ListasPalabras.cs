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
            //palabras desorganizadas español
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
            listaPalabras.Add("auln");//luna
            listaPalabras.Add("egufo");//fuego
            listaPalabras.Add("ugaa");//agua
            listaPalabras.Add("aneplat");//planeta
            listaPalabras.Add("heteco");//cohete
            listaPalabras.Add("ejaba");//abeja
            listaPalabras.Add("jarapo");//pajaro
            listaPalabras.Add("neatan");//antena
            listaPalabras.Add("lenofote");//telefono
            listaPalabras.Add("tebolla");//botella
            listaPalabras.Add("lucelar");//celular
            listaPalabras.Add("nataven");//ventana
            listaPalabras.Add("orofesam");//semaforo
            listaPalabras.Add("tañanom");//montaña
            listaPalabras.Add("esohu");//hueso
            listaPalabras.Add("fedicioi");//edificio
            listaPalabras.Add("lismi");//misil
            listaPalabras.Add("cimarano");//marciano
            listaPalabras.Add("sopamari");//mariposa
            listaPalabras.Add("regit");//tigre
            listaPalabras.Add("butiron");//tiburon
            listaPalabras.Add("lednif");//delfin
            listaPalabras.Add("veralaca");//calavera
            listaPalabras.Add("bool");//lobo
            listaPalabras.Add("tapucomdor");//computador
            listaPalabras.Add("nalliga");//gallina
            listaPalabras.Add("pazato");//zapato
            listaPalabras.Add("ramelpa");//palmera
            listaPalabras.Add("noformico");//microfono
            listaPalabras.Add("campechin");//chimpance

            //palabras organizadas español.
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
            listaPalabrasorg.Add("luna");//luna
            listaPalabrasorg.Add("fuego");//fuego
            listaPalabrasorg.Add("agua");//agua
            listaPalabrasorg.Add("planeta");//planeta
            listaPalabrasorg.Add("cohete");//cohete
            listaPalabrasorg.Add("abeja");//abeja
            listaPalabrasorg.Add("pajaro");//pajaro
            listaPalabrasorg.Add("antena");//antena
            listaPalabrasorg.Add("telefono");//telefono
            listaPalabrasorg.Add("botella");//botella
            listaPalabrasorg.Add("celular");//celular
            listaPalabrasorg.Add("ventana");//ventana
            listaPalabrasorg.Add("semaforo");//semaforo
            listaPalabrasorg.Add("montaña");//montaña
            listaPalabrasorg.Add("hueso");//hueso
            listaPalabrasorg.Add("edificio");//edificio
            listaPalabrasorg.Add("misil");//misil
            listaPalabrasorg.Add("marciano");//marciano
            listaPalabrasorg.Add("mariposa");//mariposa
            listaPalabrasorg.Add("tigre");//tigre
            listaPalabrasorg.Add("tiburon");//tiburon
            listaPalabrasorg.Add("delfin");//delfin
            listaPalabrasorg.Add("calavera");//calavera
            listaPalabrasorg.Add("lobo");//lobo
            listaPalabrasorg.Add("computador");//computador
            listaPalabrasorg.Add("gallina");//gallina
            listaPalabrasorg.Add("zapato");//zapato
            listaPalabrasorg.Add("palmera");//palmera
            listaPalabrasorg.Add("microfono");//microfono
            listaPalabrasorg.Add("chimpance");//chimpance
            tamaño = listaPalabras.Count;


        }
        else {

            //palabras ingles desorganizadas
            listaPalabras.Add("onom");//moon
            listaPalabras.Add("rife");//fire
            listaPalabras.Add("tawer");//water
            listaPalabras.Add("netlap");//planet
            listaPalabras.Add("teckor");//rocket
            listaPalabras.Add("fliryfe");//firefly
            listaPalabras.Add("dirb");//bird
            listaPalabras.Add("tellasite");//satellite
            listaPalabras.Add("oneph");//phone
            listaPalabras.Add("telbot");//bottle
            listaPalabras.Add("martspheno");//smartphone
            listaPalabras.Add("nwdiow");//window
            listaPalabras.Add("fraywee");//freeway
            listaPalabras.Add("untaimno");//mountain
            listaPalabras.Add("nobe");//bone
            listaPalabras.Add("dibuling");//building
            listaPalabras.Add("lissime");//missile
            listaPalabras.Add("nilae");//alien
            listaPalabras.Add("futtyberl");//butterfly
            listaPalabras.Add("tregi");//tiger
            listaPalabras.Add("krash");//shark
            listaPalabras.Add("pholdin");//dolphin
            listaPalabras.Add("kllus");//skull
            listaPalabras.Add("flow");//wolf
            listaPalabras.Add("potlap");//laptop
            listaPalabras.Add("heckcin");//chicken
            listaPalabras.Add("ehos");//shoe
            listaPalabras.Add("palm");//lamp
            listaPalabras.Add("crimonepho");//microphone
            listaPalabras.Add("yomken");//monkey
            listaPalabras.Add("rete");//tree
            listaPalabras.Add("owlref");//flower
            listaPalabras.Add("vole");//love
            listaPalabras.Add("grisfen");//fingers
            listaPalabras.Add("richa");//chair
            listaPalabras.Add("hesou");//house
            listaPalabras.Add("arc");//car
            listaPalabras.Add("cliceromto");//motorcicle
            listaPalabras.Add("taych");//yatch
            listaPalabras.Add("kanb");//bank
            listaPalabras.Add("grof");//frog
            listaPalabras.Add("god");//dog
            listaPalabras.Add("tac");//cat
            listaPalabras.Add("letba");//table
            listaPalabras.Add("cecylib");//bicycle
            listaPalabras.Add("salgg");//glass
            listaPalabras.Add("lepat");//plate
            listaPalabras.Add("ppale");//apple
            listaPalabras.Add("nipeppale");//pineapple
            listaPalabras.Add("drinchel");//children
            listaPalabras.Add("lirg");//girl
            listaPalabras.Add("bolaon");//baloon
            listaPalabras.Add("roccse");//soccer
            listaPalabras.Add("danh");//hand
            listaPalabras.Add("ofot");//foot
            listaPalabras.Add("seon");//nose
            listaPalabras.Add("adeh");//head
            listaPalabras.Add("syee");//eyes
            listaPalabras.Add("egnaro");//orange
            listaPalabras.Add("uns");//sun 

            //palabras ingles organizadas
            listaPalabrasorg.Add("moon");//moon
            listaPalabrasorg.Add("fire");//fire
            listaPalabrasorg.Add("water");//water
            listaPalabrasorg.Add("planet");//planet
            listaPalabrasorg.Add("rocket");//rocket
            listaPalabrasorg.Add("firefly");//firefly
            listaPalabrasorg.Add("bird");//bird
            listaPalabrasorg.Add("satellite");//satellite
            listaPalabrasorg.Add("phone");//phone
            listaPalabrasorg.Add("bottle");//bottle
            listaPalabrasorg.Add("smartphone");//smartphone
            listaPalabrasorg.Add("window");//window
            listaPalabrasorg.Add("freeway");//freeway
            listaPalabrasorg.Add("mountain");//mountain
            listaPalabrasorg.Add("bone");//bone
            listaPalabrasorg.Add("building");//building
            listaPalabrasorg.Add("missile");//missile
            listaPalabrasorg.Add("alien");//alien
            listaPalabrasorg.Add("butterfly");//butterfly
            listaPalabrasorg.Add("tiger");//tiger
            listaPalabrasorg.Add("shark");//shark
            listaPalabrasorg.Add("dolphin");//dolphin
            listaPalabrasorg.Add("skull");//skull
            listaPalabrasorg.Add("wolf");//wolf
            listaPalabrasorg.Add("laptop");//laptop
            listaPalabrasorg.Add("chicken");//chicken
            listaPalabrasorg.Add("shoe");//shoe
            listaPalabrasorg.Add("lamp");//lamp
            listaPalabrasorg.Add("microphone");//microphone
            listaPalabrasorg.Add("monkey");//monkey
            listaPalabrasorg.Add("tree");//tree
            listaPalabrasorg.Add("flower");//flower
            listaPalabrasorg.Add("love");//love
            listaPalabrasorg.Add("fingers");//fingers
            listaPalabrasorg.Add("chair");//chair
            listaPalabrasorg.Add("house");//house
            listaPalabrasorg.Add("car");//car
            listaPalabrasorg.Add("motorcicle");//motorcicle
            listaPalabrasorg.Add("yatch");//yatch
            listaPalabrasorg.Add("bank");//bank
            listaPalabrasorg.Add("frog");//frog
            listaPalabrasorg.Add("dog");//dog
            listaPalabrasorg.Add("cat");//cat
            listaPalabrasorg.Add("table");//table
            listaPalabrasorg.Add("bicycle");//bicycle
            listaPalabrasorg.Add("glass");//glass
            listaPalabrasorg.Add("plate");//plate
            listaPalabrasorg.Add("apple");//apple
            listaPalabrasorg.Add("pineapple");//pineapple
            listaPalabrasorg.Add("children");//children
            listaPalabrasorg.Add("girl");//girl
            listaPalabrasorg.Add("baloon");//baloon
            listaPalabrasorg.Add("soccer");//soccer
            listaPalabrasorg.Add("hand");//hand
            listaPalabrasorg.Add("foot");//foot
            listaPalabrasorg.Add("nose");//nose
            listaPalabrasorg.Add("head");//head
            listaPalabrasorg.Add("eyes");//eyes
            listaPalabrasorg.Add("orange");//orange
            listaPalabrasorg.Add("sun");//sun
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
