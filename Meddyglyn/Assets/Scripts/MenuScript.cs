using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject playerCamera;

    public void PlayGame()
    {

        playerCamera.SetActive(true);
        gameUI.SetActive(true);
        player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;

        this.gameObject.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

}
