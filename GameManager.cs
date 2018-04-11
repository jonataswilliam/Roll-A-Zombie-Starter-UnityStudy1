using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour {

    private int selectedZombiePosition;
    public GameObject selectedZombie; // Variável para armazenar o zombie selecinado
    public List<GameObject> zombies; //Cria uma array para add os zombies
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    // Use this for initialization
    void Start () {
        SelectZombie(selectedZombie);
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("left")) { 

        }

        if(Input.GetKeyDown("right")) {

        }

        if (Input.GetKeyDown("up")) {

        }
    }

    void GetZombieLeft () {
        if( selectedZombiePosition == 0 ) {
            SelectZombie(zombies[3]);
        } else {
            GameObject newZombie = zombies[selectedZombiePosition - 1];
        }
    }


    void SelectZombie (GameObject newZombie) {
        newZombie.transform.localScale = selectedSize;
    }

    
}
