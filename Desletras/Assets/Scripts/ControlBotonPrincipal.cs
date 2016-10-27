using UnityEngine;
using System.Collections;

public class ControlBotonPrincipal : MonoBehaviour {



    [SerializeField]
    private GameObject boton;
    // Use this for initialization

    void Awake() {
        boton.SetActive(false);
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnActivarBoton() {
        boton.SetActive(true);
    }
}
