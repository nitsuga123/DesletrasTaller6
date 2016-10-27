using UnityEngine;
using System.Collections;

public class transiciones : MonoBehaviour {


    private Animator anim;

    
	// Use this for initialization
	void Start () {
	 anim= GetComponent<Animator>();
	}
    void onEnable()
    {
        StartCoroutine(trans());
    }
    // Update is called once per frame
    void Update () {
	
	}

    IEnumerator trans(){
        yield return new WaitForSeconds(1f);
        yield return new WaitForSeconds(0.1f);
    }
}
