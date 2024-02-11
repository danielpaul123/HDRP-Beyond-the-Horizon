using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelwin : MonoBehaviour
{
    public int enenmies = 0;

    public GameObject gamewinpanel;
    // Start is called before the first frame update
    void Start()
    {
        gamewinpanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enenmies == 12)
        {
            gamewinpanel.SetActive(true);
        }
    }

    
}
