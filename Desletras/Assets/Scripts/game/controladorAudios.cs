using UnityEngine;
using System.Collections;

public class controladorAudios : MonoBehaviour {

    private GameMaster state;
    private int controladorCo;

    [SerializeField]
    private AudioSource MusicaPrincipal;

    [SerializeField]
    private AudioSource Graficador;

    [SerializeField]
    private AudioSource resultados;

    [SerializeField]
    private AudioSource ganador;

    [SerializeField]
    private AudioSource creditos;

    private bool cont;


    // Use this for initialization
    void Start () {
        controladorCo = 0;
        cont = false;
        GameObject gm = GameObject.Find("GameMaster");
        state = gm.GetComponent<GameMaster>();
    }
	
	// Update is called once per frame
	void Update () {
        
        
        switch (state.GetgameState()) {
            case GameStates.PGame:
            case GameStates.Pant1:
                if (!MusicaPrincipal.isPlaying)
                {
                    creditos.Stop();
                    resultados.Stop();
                    MusicaPrincipal.Play();
                }
                
                break;

            case GameStates.Graf:
                controladorCo = 0;
                if (!Graficador.isPlaying)
                {
                    MusicaPrincipal.Stop();
                    Graficador.Play();
                }
                
                break;

            case GameStates.resultado1:
                if (!resultados.isPlaying) {
                    Graficador.Stop();
                    StartCoroutine(EsperaFades());
                    
                }

                break;

            case GameStates.Ganador:
                if (!ganador.isPlaying) {
                    if (cont == false)
                    {
                        resultados.volume = 0.2f;
                        ganador.Play();
                        cont = true;
                    }
  
                }
            
               break;

            case GameStates.credit:
                if (!creditos.isPlaying) {
                       
                        resultados.Stop();
                        ganador.Stop();
                        creditos.Play();
                       
                   
                    
                }
                
                break;



        }
	}

    IEnumerator EsperaFades() {
        if (controladorCo == 0) {
            yield return new WaitForSeconds(0.2f);
            resultados.Play();
            controladorCo = 1;
        }
        
    }
}
