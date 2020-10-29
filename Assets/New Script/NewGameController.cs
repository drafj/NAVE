using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameController : MonoBehaviour
{
    public Transform safeBox;
    public Transform targetR;
    public Transform targetC;

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
        
        for (int i = 0; i <  5; i++)
        {
            GameObject temp = Instantiate(m_rock, safeBox.localPosition, Quaternion.identity);
            rock[i] = temp;
            temp.SetActive(false);
           
        }
        for (int j = 0; j < 5; j++)
        {
            GameObject temp = Instantiate(m_clock, safeBox.localPosition, Quaternion.identity);
            clock[j] =
                temp;
            temp.SetActive(false);
        }
        InvokeRepeating("Asteroid",3,2);
        InvokeRepeating("TimeRelease",5,10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Asteroid()
    {
        targetR.position = new Vector2(Random.Range(-1,6), targetR.position.y);
        rock[p].SetActive(true);
        rock[p].transform.position = new Vector2(targetR.position.x, targetR.position.y);
        p++;
        if(p == 5)
        {
            p = 0;
        }
    }
    void TimeRelease()
    {
        {
            targetC.position = new Vector2(Random.Range(-1, 6), targetC.position.y);
            clock[p].SetActive(true);
            clock[p].transform.position = new Vector2(targetC.position.x, targetC.position.y);
            p++;
            if (p == 5)
            {
                p = 0;
            }
        }
    }
}
