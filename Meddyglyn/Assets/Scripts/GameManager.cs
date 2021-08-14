using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject player;
    public void PauseGame()
    {
        if (!mainMenu.activeSelf)
        {
            mainMenu.SetActive(true);
            gameUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            player.GetComponent<FirstPersonController>().enabled = false;
            Time.timeScale = 0;

        }

        else if (mainMenu.activeSelf)
        {
            Time.timeScale = 1f;
            mainMenu.SetActive(false);
            gameUI.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<FirstPersonController>().enabled = true;
        }
    }

}
