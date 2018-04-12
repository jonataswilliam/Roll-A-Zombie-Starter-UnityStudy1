using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour {

    private int selectedZombiePosition;
    public GameObject selectedZombie; // Variável para armazenar o zombie selecinado
    //public List<GameObject> zombies; //Cria uma array para add os zombies
    public GameObject[] zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    // Use this for initialization
    void Start () {
        SelectZombie(0);
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown("left")) {
            GetZombieLeft();
        }

        if(Input.GetKeyDown("right")) {
            GetZombieRight();
        }

        if (Input.GetKeyDown("up")) {

        }
    }

    void GetZombieLeft () {
        if( selectedZombiePosition == 0 ) {
            SelectZombie(zombies.Length);
        } else {            
            SelectZombie(selectedZombiePosition - 1);
        }
    }

    void GetZombieRight () {
         if (selectedZombiePosition == zombies.Length) {
            SelectZombie(0);
        } else {
            SelectZombie(selectedZombiePosition + 1);
        }
    }


    void SelectZombie (int IndexNewZombie) {
        zombies[selectedZombiePosition].transform.localScale = defaultSize;
        zombies[IndexNewZombie].transform.localScale = selectedSize;
    }

    
}
