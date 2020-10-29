using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform safeBox;
    public Transform target;

    [Space]
    public GameObject m_rock;
    public GameObject m_clock;
    public GameObject[] rock;
    public GameObject[] clock;



    int rango = 5;
    int p;



    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 5; i++)
        {
            rock[i] = Instantiate(m_rock, safeBox.localPosition, Quaternion.identity);


        }
        for (int j = 0; j < 5; j++)
        {
            clock[j] = Instantiate(m_clock, safeBox.localPosition, Quaternion.identity);
        }
        InvokeRepeating("Asteroid", 3, 2);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void Asteroid()
    {
        rock[p].transform.position = target.position;
        p++;
        if (p > 5)
        {
            p = 0;
        }
    }
}
