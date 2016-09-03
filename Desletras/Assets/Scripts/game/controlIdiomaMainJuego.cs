using UnityEngine;
using System.Collections;

public class controlIdiomaMainJuego : MonoBehaviour {


    void Awake() {
        
    }
	// Use this for initialization
	void Start () {
        switch (cambioIdioma.idioma)
        {
            case true:
                gameObject.GetComponent<cambioTextos>().enabled = true;
                gameObject.GetComponent<cambiosTextosENG>().enabled = false;
                break;

            case false:
                gameObject.GetComponent<cambioTextos>().enabled = false;
                gameObject.GetComponent<cambiosTextosENG>().enabled = true;
                break;


        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
