using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


public class AdminSQl : MonoBehaviour
{
    //Variables para la conexión
    private string datosConexion;
    private MySqlConnection connection;

    public GameObject _mensaje;
    //public InputField input;
    //public int numero = 1;



    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(System.Environment.Version);

        datosConexion = "Server=162.241.60.30;Database=mycluble_bdJuego;Uid=myclublearning;Pwd=C0l0mb1a2020*;"; 
        ConectarConServidorBaseDatos();
    }

    public void ConectarConServidorBaseDatos()
    {
        connection = new MySqlConnection(datosConexion);


        try
        {
            connection.Open(); 
            Debug.Log("Conexión establecida correctamente");
            //_mensaje.SetActive(true);

            
        }
        catch (MySqlException error)
        {
            Debug.Log("Conexión fallida" + error);
        }
    }

    public MySqlDataReader Select(string _select)
    {
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM " + _select;
        MySqlDataReader resultado = command.ExecuteReader();
        return resultado;
    }

    public MySqlDataReader Insert(string _insert)
    {
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO " + _insert;
        MySqlDataReader resultado = command.ExecuteReader();
        return resultado;
    }

    /*public void logear()
    {
        string _log = "usuarios WHERE BINARY usuario LIKE'" + _txtUsuario.text + "'";

        AdminSQl _adminSql = GameObject.Find("AdminBD").GetComponent<AdminSQl>();
        MySqlDataReader resultado = _adminSql.Select(_log);


        if (resultado.HasRows)
        {
            Debug.Log("Logeo correcto");
            resultado.Close();
        }
        else
        {
            Debug.Log("Usuario no encontrado");
            resultado.Close();
        }
    }*/













    /*public void consultaSelect()
    {

        try
        {
            string infoDB = "Server=localhost;Database=prueba_uno;Uid=root;Pwd=0000;";

            //string select = "INSERT INTO usuarios (usuario) VALUES ('" + input.text  + "');";
            
            string consulta = "UPDATE usuarios set usuario = '" + input.text + "'WHERE id = '" + numero+ "';";
          //  "update usuarios set usuario='" + input.text + "' where id = '" 1  + "';";
            //"UPDATE meal.claves set usuario='" + user.Text + "where clave ='" + pass + "'";

            MySqlConnection connection = new MySqlConnection(infoDB);
            MySqlCommand consola = new MySqlCommand(consulta, connection);

            connection.Open();

            consola.ExecuteReader();

            //connection.Close();


        }
        catch(MySqlException error)
        {
            Debug.Log("Conexión fallida" + error);
        }
    }


    public void consultaInsert()
    {

        try
        {
            string infoDB = "Server=localhost;Database=prueba_uno;Uid=root;Pwd=0000;";

            string consulta = "INSERT INTO usuarios (usuario) VALUES ('" + input.text + "');";

            //string consulta = "UPDATE usuarios set usuario = '" + input.text + "'WHERE id = '" + numero + "';";
            //  "update usuarios set usuario='" + input.text + "' where id = '" 1  + "';";
            //"UPDATE meal.claves set usuario='" + user.Text + "where clave ='" + pass + "'";

            MySqlConnection connection = new MySqlConnection(infoDB);
            MySqlCommand consola = new MySqlCommand(consulta, connection);

            connection.Open();

            consola.ExecuteReader();

            //connection.Close();


        }
        catch (MySqlException error)
        {
            Debug.Log("Conexión fallida" + error);
        }
    }


    public void consultaDelete()
    {

        try
        {
            string infoDB = "Server=localhost;Database=prueba_uno;Uid=root;Pwd=0000;";

            string consulta = "DELETE FROM usuarios WHERE id = '" + numero + "';";

            //string consulta = "UPDATE usuarios set usuario = '" + input.text + "'WHERE id = '" + numero + "';";
            //  "update usuarios set usuario='" + input.text + "' where id = '" 1  + "';";
            //"UPDATE meal.claves set usuario='" + user.Text + "where clave ='" + pass + "'";

            MySqlConnection connection = new MySqlConnection(infoDB);
            MySqlCommand consola = new MySqlCommand(consulta, connection);

            connection.Open();

            consola.ExecuteReader();

            //connection.Close();


        }
        catch (MySqlException error)
        {
            Debug.Log("Conexión fallida" + error);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/
}
