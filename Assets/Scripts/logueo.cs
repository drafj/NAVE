using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;
using System.Data;
using UnityEngine.SceneManagement;
using Assets.nueva;

public class logueo : MonoBehaviour
{
    public InputField _txtUsuario;
    public InputField _txtContrasena;
    public InputField _txtConfirmarContrasena;

    public GameObject _login;
    public GameObject _registro;

    public GameObject _mensajeCaracteresU;
    public GameObject _mensajeCaracteresC;
    public GameObject _mensajeUsuarioExiste;
    public GameObject _mensajeContrasenaNoCoicide;

    public GameObject _mensajeusuarioNoE;

    //pasar datos
    public string idUsuario;
    public string nombreUsuario;

    public GameObject gameObjectVideo;
    public GameObject gameObjectInterfas;
    public GameObject btn;
    public Button btnboton;

    ClaseGet c = new ClaseGet();
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void logear()
    {
        string _log = "usuarios WHERE BINARY usuario LIKE'" + _txtUsuario.text + "'AND contrasena LIKE '" + _txtContrasena.text + "'";

        AdminSQl _adminSql = GameObject.Find("AdminBD").GetComponent<AdminSQl>();
        MySqlDataReader resultado = _adminSql.Select(_log);

        if (resultado.HasRows)
        {
            Debug.Log("Logeo correcto");
            PlayerPrefs.SetString("usuario", _txtUsuario.text);
            gameObjectVideo.SetActive(true);
            gameObjectInterfas.SetActive(false);
            btn.SetActive(true);
            //StartCoroutine("Esperar");
            
            Debug.Log(nombreUsuario.ToString());
            resultado.Close();
            //DontDestroyOnLoad(_login);
        }
        else
        {
            Debug.Log("Usuario no encontrado");
            resultado.Close();
            _mensajeusuarioNoE.SetActive(true);
        }
    }

    public void RegistrarNuevoUsuario()
    {
        _mensajeusuarioNoE.SetActive(false);
        if (_txtUsuario.text.Length >= 8)
        {

            if (!_txtContrasena.text.Equals("") && !_txtConfirmarContrasena.text.Equals(""))
            {

                if (_txtContrasena.text == _txtConfirmarContrasena.text)
                {

                    if (_txtContrasena.text.Length >= 8 && _txtConfirmarContrasena.text.Length >= 8)
                    {

                        string _log = "usuarios WHERE BINARY usuario LIKE'" + _txtUsuario.text + "'";
                        AdminSQl _adminSql = GameObject.Find("AdminBD").GetComponent<AdminSQl>();
                        MySqlDataReader resultado = _adminSql.Select(_log);


                        if (resultado.HasRows)
                        {


                            _mensajeUsuarioExiste.SetActive(true);

                            _mensajeCaracteresU.SetActive(false);

                            _mensajeContrasenaNoCoicide.SetActive(false);


                            _mensajeCaracteresC.SetActive(false);


                            _mensajeusuarioNoE.SetActive(false);


                            resultado.Close();



                        }
                        else
                        {
                            resultado.Close();

                            //_log = "usuarios (usuario, contrasena) values('" +txtUsuario.text+ "','" +txtContrasena.text+ "');";
                            _log = "usuarios (usuario, contrasena) values('" + this._txtUsuario.text + "','" + _txtContrasena.text + "');";
                            resultado = _adminSql.Insert(_log);
                            Debug.Log("Se creo");
                            resultado.Close();
                            AbrirCerrarRegistro();

                            _mensajeCaracteresC.SetActive(false);

                            _mensajeContrasenaNoCoicide.SetActive(false);

                            _mensajeUsuarioExiste.SetActive(false);

                            _mensajeCaracteresU.SetActive(false);

                            _mensajeusuarioNoE.SetActive(false);

                        }

                    }
                    else
                    {

                        _mensajeCaracteresC.SetActive(true);

                        _mensajeContrasenaNoCoicide.SetActive(false);

                        _mensajeUsuarioExiste.SetActive(false);

                        _mensajeCaracteresU.SetActive(false);

                        _mensajeusuarioNoE.SetActive(false);

                    }


                }
                else
                {

                    _mensajeContrasenaNoCoicide.SetActive(true);

                    _mensajeUsuarioExiste.SetActive(false);

                    _mensajeCaracteresU.SetActive(false);

                    _mensajeUsuarioExiste.SetActive(false);

                    _mensajeusuarioNoE.SetActive(false);

                }

            }
            else
            {


                //_mensajeContrasenaNoCoicide.SetActive(true);
                _mensajeUsuarioExiste.SetActive(false);

                _mensajeCaracteresU.SetActive(false);
                _mensajeUsuarioExiste.SetActive(false);
                _mensajeContrasenaNoCoicide.SetActive(false);

                _mensajeusuarioNoE.SetActive(false);

                Debug.Log("Debes llenar los campos de ontraseña");


            }

            //_mensajeCaracteresU.SetActive(true);
            //_mensajeUsuarioExiste.SetActive(false);
        }
        else
        {


            _mensajeCaracteresU.SetActive(true);
            _mensajeUsuarioExiste.SetActive(false);
            _mensajeCaracteresC.SetActive(false);
            _mensajeContrasenaNoCoicide.SetActive(false);

            _mensajeusuarioNoE.SetActive(false);
        }
    }

    public void AbrirCerrarRegistro()
    {
        if (_login.activeSelf)
        {

            _login.SetActive(false);
            _registro.SetActive(true);
            _mensajeusuarioNoE.SetActive(false);

        }
        else
        {
            _login.SetActive(true);
            _registro.SetActive(false);

        }

    }

   /* IEnumerator esperar()
    {
        yield return new  WaitForSeconds(4);
        SceneManager.LoadScene(1);
        Debug.Log("atrapadaaaa");
        gameObjectInterfas.SetActive(true);
    }*/




    /*public void RegistrarNuevoUsuario()
    {


        if (_txtUsuario.text.Length >= 8)
        {

            if (!_txtContrasena.text.Equals("") && !_txtConfirmarContrasena.text.Equals(""))
            {

                if (_txtContrasena.text == _txtConfirmarContrasena.text)
                {

                    if (_txtContrasena.text.Length >= 8 && _txtConfirmarContrasena.text.Length >= 8)
                    {

                        string _log = "usuarios WHERE BINARY usuario LIKE'" + _txtUsuario.text + "'";
                        AdminSQl _adminSql = GameObject.Find("AdminBD").GetComponent<AdminSQl>();
                        MySqlDataReader resultado = _adminSql.Select(_log);


                        if (resultado.HasRows)
                        {


                            _mensajeUsuarioExiste.SetActive(true);

                            _mensajeCaracteresU.SetActive(false);

                            _mensajeContrasenaNoCoicide.SetActive(false);


                            _mensajeCaracteresC.SetActive(false);


                            resultado.Close();



                        }
                        else
                        {
                            resultado.Close();

                            //_log = "usuarios (usuario, contrasena) values('" +txtUsuario.text+ "','" +txtContrasena.text+ "');";
                            _log = "usuarios (usuario, contrasena) values('" + this._txtUsuario.text + "','" + _txtContrasena.text + "');";
                            resultado = _adminSql.Insert(_log);
                            Debug.Log("Se creo");
                            resultado.Close();
                            AbrrirCerrarRegistro();

                            _mensajeCaracteresC.SetActive(false);

                            _mensajeContrasenaNoCoicide.SetActive(false);

                            _mensajeUsuarioExiste.SetActive(false);

                            _mensajeCaracteresU.SetActive(false);

                        }

                    }
                    else
                    {

                        _mensajeCaracteresC.SetActive(true);

                        _mensajeContrasenaNoCoicide.SetActive(false);

                        _mensajeUsuarioExiste.SetActive(false);

                        _mensajeCaracteresU.SetActive(false);

                    }


                }
                else
                {

                    _mensajeContrasenaNoCoicide.SetActive(true);

                    _mensajeUsuarioExiste.SetActive(false);

                    _mensajeCaracteresU.SetActive(false);
                    _mensajeUsuarioExiste.SetActive(false);

                }

            }
            else
            {


                //_mensajeContrasenaNoCoicide.SetActive(true);
                _mensajeUsuarioExiste.SetActive(false);

                _mensajeCaracteresU.SetActive(false);
                _mensajeUsuarioExiste.SetActive(false);
                _mensajeContrasenaNoCoicide.SetActive(false);

                Debug.Log("Debes llenar los campos de ontraseña");


            }

            //_mensajeCaracteresU.SetActive(true);
            //_mensajeUsuarioExiste.SetActive(false);
        }
        else
        {


            _mensajeCaracteresU.SetActive(true);
            _mensajeUsuarioExiste.SetActive(false);
            _mensajeCaracteresC.SetActive(false);
            _mensajeContrasenaNoCoicide.SetActive(false);
        }
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnSaltarVideo()
    {
       // PlayerPrefs.SetString("usuario", _txtUsuario.text);
        SceneManager.LoadScene(2);

    }
}
