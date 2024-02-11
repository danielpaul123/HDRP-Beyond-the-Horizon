using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlvl : MonoBehaviour
{
    [Header("Gate button")]
    [SerializeField] private KeyCode GateButton = KeyCode.E;

    [Header("Generator Sound Effects and radius")]
    private float radius = 5f;
    public playerscript player;

    private void Update()
    {
        if (Input.GetKeyDown(GateButton) && Vector3.Distance(transform.position, player.transform.position) < radius)
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("New Scene");
            Cursor.lockState = CursorLockMode.None;

           
        }
    }
}