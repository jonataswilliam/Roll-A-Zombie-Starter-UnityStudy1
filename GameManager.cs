using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {
    public Text scoreText;
    private int score;
    private int selectedZombiePosition;
    public GameObject selectedZombie;   // Variável para armazenar o zombie selecinado
    //public List<GameObject> zombies;  //Cria uma array para add os zombies
    public GameObject[] zombies;        //Cria uma array para add os zombies
    public Vector3 selectedSize;        // Tamanho para o zombie Selecionado (1.4)
    public Vector3 defaultSize;         // Tamanho para o zombie Selecionado (1)   

    // Use this for initialization
    void Start () {
        SelectZombie(0);
        scoreText.text = "Score: " + score;
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
            PushUp();
        }
    }

    void GetZombieLeft () {
        if( selectedZombiePosition == 0 ) {
            SelectZombie(zombies.Length-1);
        } else {            
            SelectZombie(selectedZombiePosition - 1);
        }
    }

    void GetZombieRight () {
         if (selectedZombiePosition == zombies.Length-1) {
            SelectZombie(0);
        } else {
            SelectZombie(selectedZombiePosition + 1);
        }
    }


    void PushUp() {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 15, ForceMode.Impulse);
    }
    

    void SelectZombie (int IndexNewZombie) {
        print(IndexNewZombie);  
        zombies[selectedZombiePosition].transform.localScale = defaultSize;
        zombies[IndexNewZombie].transform.localScale = selectedSize;
        selectedZombiePosition = IndexNewZombie;  
        selectedZombie = zombies[IndexNewZombie]; // Armazenando novo zombie selecionado
    }


    public void AddPoint () {
        score = score + 1;
        scoreText.text = "Score:" + score;
    }

    
}
