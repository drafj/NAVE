using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System.Data;
using UnityEngine.SceneManagement;

public class Nave : MonoBehaviour
{
    public GameObject nave;

   /* public Text pregunta;
    public Text respuesta1;
    public Text respuesta2;

    public Button btnRespuesta1;
    public Button btnRespuesta2;


    public Button empezar;

    logueo lo;

    public Text tiempoText;
    public float tiempo = 200.0f;


    public DataColumn data;

    public DataTable Dtt = null;

    public GameObject canvasPreguntas;
    public GameObject relojito;*/

    private Animator animator;

    // Start is called before the first frame update

    void Awake()
    {
        
    }
    void Start()
    {
        //empezarrr();
        //animator = GetComponent<Animator>();
    }

    /*public void UpdateState(string state = null)
    {

        if (state != null)
        {
            animator.Play(state);
        }

    }*/

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.2f, 0, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.2f, 0, 0);

        }
    }

    

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




        if (other.gameObject.tag == "reloj")
        {
            Debug.Log("tocó el reloj");

            //Destroy(gameObject);

            //other.SendMessage("dano", SendMessageOptions.DontRequireReceiver);
            //UpdateState("explosion");


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

           

        }
    }






    /*public void logear()
    {
        //string _log = "usuarios WHERE BINARY usuario LIKE'" + _txtUsuario.text + "'AND contrasena LIKE '" + _txtContrasena.text + "'";
        string _log = "usuarios ORDER BY RAND()";

        AdminSQl _adminSql = GameObject.Find("AdminBD").GetComponent<AdminSQl>();
        MySqlDataReader resultado = _adminSql.Select(_log);
        Dtt = new DataTable();
        Dtt.Load(resultado);

        if (Dtt.Rows.Count > 0)
        {

            Debug.Log("Logeo correcto");
            //PlayerPrefs.SetString("usuario", _txtUsuario.text);
            //SceneManager.LoadScene("Scena2");


            pregunta.text = Dtt.Rows[0][1].ToString();
            respuesta1.text = Dtt.Rows[0][2].ToString();
            respuesta2.text = Dtt.Rows[0][3].ToString();
            

           
            
            

            Debug.Log("HOLA LOGUEO");
            resultado.Close();
            //DontDestroyOnLoad(_login);
        }
        else
        {
            Debug.Log("Usuario no encontrado");
            resultado.Close();
        }
    }*/

    /*public void OnTriggerEnter2D(Collider2D other)
    {
        
        //var yourVar = false;

        if (other.gameObject.tag == "relojito")
        {
            //Debug.Log("Holaa");
            //nave.SetActive(false);
            //relojito.SetActive(false);
            //canvasPreguntas.SetActive(false);
            

            //logear();

            //logueo logueo = new logueo();

            /*lo = GameObject.FindGameObjectWithTag("tagLoguer").GetComponent<logueo>();
            lo.logear();*/

    //Destroy(gameObject);
    //SceneManager.LoadScene("Segunda");

    // yourVar = true;

    // }

    /*if (other.gameObject.tag == "relojito")
    {
        Debug.Log("Holaa");
        nave.SetActive(false);

        //Destroy(gameObject);
        //SceneManager.LoadScene("Segunda");

    }*/
    //}




   /* public void btnSi()
    {
        if (respuesta1.text == "")
        {
            pregunta.text = "hola, esta está mala".ToString();

            /*tiempo = 20;
            tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0");
        }
        else
        {
           /*tiempo = 30;
            tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0");
            //nave.SetActive(false);
            Debug.Log("esta es la respuesta correcta");
        }
        
        
    }

    public void btnNo()
    {
        if (respuesta2.text == "")
        {
            pregunta.text = "La respuesta no es incorrecta".ToString();

            /*tiempo = 40;
            tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0");
        }
        else
        {
            //Debug.Log("esta es la respuesta correcta");
           /* tiempo = 50;
            tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0");
            //nave.SetActive(false);
            Debug.Log("esta es la respuesta correcta");
        }
    }*/

    
}
