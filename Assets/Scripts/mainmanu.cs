using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmanu : MonoBehaviour
{
    public void onplaybutton()
    {
        SceneManager.LoadScene("MINPRO");
        Debug.Log("Loading Game....");
    }
    public void onquittbutton()
    {
        Application.Quit();
        Debug.Log("Quitting Game....");
    }
}
