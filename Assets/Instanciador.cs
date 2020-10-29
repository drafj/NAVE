using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instanciador : MonoBehaviour
{
    public float InstanceRate = 5;
    public GameObject AsteroidePrefab;

    public GameObject nave;

    private Animator animator;
    /* public GameObject relojIz;
     public GameObject relojDe;*/

    //public Text tiempoText;
    //public float tiempo = 0.0f;

    //public GameObject tiempo1;
    //public GameObject tiempo2;


    /*void Start()
    {
        animator = GetComponent<Animator>();
    }*/

    IEnumerator Start()
    {
        /*tiempo -= Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0");*/
        //animator = GetComponent<Animator>();


        while (true)
        
        {
            Instantiate (AsteroidePrefab, transform.position, Quaternion.identity);

            Debug.Log("Se chocó contra la nave la piedra");



            yield return new WaitForSeconds(InstanceRate);
            //nave.SetActive(true);;
        }
    }

    bool yourVar;




    /*public void UpdateState(string state = null)
    {

        if (state != null)
        {
            animator.Play(state);
        }

    }*/
    void OnTriggerEnter2D(Collider2D other)
    {
        //var yourVar = false;
        /*if (other.gameObject.tag == "Player")
        {
            Debug.Log("Holaa");
            nave.SetActive(false);

            

            //Destroy(gameObject);
            //SceneManager.LoadScene("Segunda");

        }*/
        

      

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("tocó el reloj");
            
            Destroy (gameObject);

            other.SendMessage("dano", SendMessageOptions.DontRequireReceiver);
           // UpdateState("explosion");


            //nave.SetActive(false);

            //tiempo1.SetActive(false);
            //tiempo2.SetActive(true);

            //tiempoText.text = "0".ToString();
            /*tiempo = 20;
            tiempo += Time.deltaTime;
            tiempoText.text = " " + tiempo.ToString("f0");

            /*tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0");*/

            //Destroy(gameObject);
            //SceneManager.LoadScene("Segunda");

            yourVar = true;

        }
    }

    public void Update()
    {

        /*tiempo -= Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0");

        if (yourVar == true)
        {

            /*tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0");*/
        //}




    }


    void OnTriggerEnter2DD(Collider2D other)
    {
        /*if (other.gameObject.tag == "Player")
        {
            Debug.Log("Holaa");
            nave.SetActive(false);;

            //Destroy(gameObject);
            //SceneManager.LoadScene("Segunda");

        }*/
    }


}
