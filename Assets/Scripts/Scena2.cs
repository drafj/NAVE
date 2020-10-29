using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scena2 : MonoBehaviour
{
    public Text usuario;
    // Start is called before the first frame update
    void Start()
    {
        usuario.text = PlayerPrefs.GetString("usuario");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
