using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reloj : MonoBehaviour
{
    public GameObject reloj;
    public GameObject preguntasC;
    public GameObject game;
    public GameObject canvas;
    public GameObject insta;
    public GameObject nave;

    
    //public Rigidbody2D rd2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Holaa");

            reloj.SetActive(false);
            preguntasC.SetActive(true);
            nave.SetActive(false);
            //game.SetActive(true);
            //canvas.SetActive(true);
            //insta.SetActive(false);
            

            


            //tiempo = 20;
            /*griloDos.SetActive(false);
            canvasPReguntas.SetActive(true);

            personaje.SetActive(false);


            //Destroy(gameObject);
            //SceneManager.LoadScene("Segunda");*/

        }
    }

    
}
