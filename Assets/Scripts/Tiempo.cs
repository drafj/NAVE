using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System.Data;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{

    public Text tiempoText;
    public float tiempo = 20.0f;


    
    public GameObject relojito;
    public GameObject canvasPreguntas1;
    public GameObject nave;


    public Text pregunta;
    public Text respuesta1;
    public Text respuesta2;

    public GameObject canvas;


    public DataColumn data;

    private string datosConexion;
    private MySqlConnection connection;

    public DataTable Dtt = null;


 

    public void ConectarConServidorBaseDatos()
    {
        connection = new MySqlConnection(datosConexion);
        try
        {
            connection.Open(); ;
            Debug.Log("Conexión establecida correctamente");
            //_mensaje.SetActive(true);
        }
        catch (MySqlException error)
        {
            Debug.Log("Conexión fallida" + error);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //datosConexion = "Server=localhost;Database=prueba_uno;Uid=root;Pwd=0000;";
        datosConexion = "Server=162.241.60.30;Database=mycluble_bdJuego;Uid=myclublearning;Pwd=C0l0mb1a2020*;";
        ConectarConServidorBaseDatos();
    }

    // Update is called once per frame
    void Update()
    {

        tiempo -= Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0");

        if (tiempoText.text == "0".ToString())
        {
            tiempoText.text = "coge la condicion del tiempo";
            canvas.SetActive(true);

            tiempo = 0;
            tiempoText.text = "" + tiempo.ToString("0");
            nave.SetActive(false);


            //tiempo -= Time.deltaTime;
            //tiempoText.text = "Error";//"" + tiempo.ToString("Error");
            //SceneManager.LoadScene(1);
        }
    }

   


    public void OnTriggerEnter2D(Collider2D other)
    {

        //var yourVar = false;

        if (other.gameObject.tag == "relojito")
        {
            Debug.Log("Holaa");
            //nave.SetActive(false);
            //relojito.SetActive(false);
            canvasPreguntas1.SetActive(true);

            

           logear();

            //logueo logueo = new logueo();

            /*lo = GameObject.FindGameObjectWithTag("tagLoguer").GetComponent<logueo>();
            lo.logear();*/

            //Destroy(gameObject);
            //SceneManager.LoadScene("Segunda");

            // yourVar = true;

        }
    }

    public MySqlDataReader Select(string _select)
    {
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM " + _select;
        MySqlDataReader resultado = command.ExecuteReader();
        return resultado;
    }


    public void logear()
    {

        //string _log = "usuarios WHERE BINARY usuario LIKE'" + _txtUsuario.text + "'AND contrasena LIKE '" + _txtContrasena.text + "'";
        string _log = "preguntas ORDER BY RAND()";

        //AdminSQl _adminSql = GameObject.Find("AdminBD").GetComponent<AdminSQl>();
        MySqlDataReader resultado = this.Select(_log);

        Dtt = new DataTable();
        Dtt.Load(resultado);

        if (Dtt.Rows.Count > 0)
        {

            Debug.Log("esta cargando...");
            //PlayerPrefs.SetString("usuario", _txtUsuario.text);
            //SceneManager.LoadScene("Scena2");


            pregunta.text = Dtt.Rows[0][0].ToString();
            respuesta1.text = Dtt.Rows[0][1].ToString();
            respuesta2.text = Dtt.Rows[0][2].ToString();
            






            Debug.Log("HOLA LOGUEO");
            resultado.Close();
            //DontDestroyOnLoad(_login);
        }
        else
        {
            Debug.Log("no hay datos");
            resultado.Close();
        }
    }

    public void btnPrueba()
    {
        float tiempo = 20.0f;
        tiempo -= Time.deltaTime;
        tiempoText.text = "" + tiempo.ToString("f0");
    }

    public void btn1()
    {
        
            if (respuesta1.text =="." && respuesta2.text =="")
            {
                tiempo = 20.0f;
                tiempo -= Time.deltaTime;
                tiempoText.text = "" + tiempo.ToString("f0" + respuesta1.text);

            }
            else
            {
                //tiempo = 10.0f;
                tiempo -= Time.deltaTime;
                tiempoText.text = "" + tiempo.ToString("f0" + respuesta1.text);
            }
        
        
        


        //logear();

        canvasPreguntas1.SetActive(false);

        nave.SetActive(true);


    }

    public void btn2()
    {
        if (respuesta2.text == "." && respuesta1.text == "")
        {
            tiempo = 20.0f;
            tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0" + respuesta1.text);

        }
        else
        {
            //tiempo = 10.0f;
            tiempo -= Time.deltaTime;
            tiempoText.text = "" + tiempo.ToString("f0" + respuesta1.text);
        }


        canvasPreguntas1.SetActive(false);

        nave.SetActive(true);
    }

    public void btnVolverIntentar()
    {
        SceneManager.LoadScene("scena 3");
    }

    public void btnVolverInicio()
    {
        SceneManager.LoadScene(0);
    }



}
