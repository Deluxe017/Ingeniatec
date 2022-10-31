using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Muros : MonoBehaviour
{
    public GameObject muros;
    public static Muros instance;
 

    private void Awake()
    {
        if(instance ==  null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        muros.SetActive(false);
    }

    public void Activator()
    {
        muros.SetActive(true);
        


    }
}
