using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUI : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    // Start is called before the first frame update

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitButton);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Pinball Game");
    }

    // Update is called once per frame
    private void ExitButton()
    {
        Application.Quit();
    }
}
