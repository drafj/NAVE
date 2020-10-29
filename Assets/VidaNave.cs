using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaNave : MonoBehaviour
{
    public int cantidadVida;
    public Image img;
    public Sprite TresVidas;
    public Sprite DosVidas;
    public Sprite UnaVida;
    public Sprite sinVidas;

    private Animator animator;

    public GameObject canvas;
    public GameObject nave;



    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        cantidadVida = 3;
        img.sprite = TresVidas;
    }

    // Update is called once per frame
    void UpdateState(string state = null) {
        
        if (state != null)
        {
            animator.Play(state);
        }
        
    }

    void UpdateStatee(string state = null)
    {

        if (state != null)
        {
            animator.Play(state);
        }

    }


    public void dano()
    {
        cantidadVida--;

        if (cantidadVida == 3)
        {
            img.sprite = TresVidas;
            
            /*nave.SetActive(false);
            nave.SetActive(true);*/
            


        }
        else if (cantidadVida == 2)
        {
            img.sprite = DosVidas;
            //UpdateState("explosion");
            //nave.SetActive(true);

            UpdateState("malo");

        }
        else if (cantidadVida == 1)
        {
            img.sprite = UnaVida;
            //UpdateState("explosion");
            //nave.SetActive(true);
            UpdateState("malo2");

        }
        else
        {
            img.sprite = sinVidas;
            canvas.SetActive(true);
            //nave.SetActive(false);
            UpdateState("explosion");
            
            //SceneManager.LoadScene("scena 3");
        }

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
