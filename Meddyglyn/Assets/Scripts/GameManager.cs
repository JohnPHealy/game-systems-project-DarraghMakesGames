using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;
    [SerializeField] private GameObject optionsMenu;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject restartButton;

    public static float batchesMade = 0;
    public static float profit;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void PauseGame()
    {
        if (!mainMenu.activeSelf)
        {
            mainMenu.SetActive(true);
            restartButton.SetActive(true);
            gameUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Confined;
            player.GetComponent<PlayerMovement>().enabled = false;
            Time.timeScale = 0;

        }

        else if (mainMenu.activeSelf || optionsMenu.activeSelf)
        {
            Time.timeScale = 1f;
            mainMenu.SetActive(false);
            optionsMenu.SetActive(false);
            gameUI.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }

}
