using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject playerCamera;

    public void PlayGame()
    {

        playerCamera.SetActive(true);
        gameUI.SetActive(true);
        player.GetComponent<FirstPersonController>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;


        mainMenu.SetActive(false);
    }

    public void Quit()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("BrewingDemo");
    }

}
