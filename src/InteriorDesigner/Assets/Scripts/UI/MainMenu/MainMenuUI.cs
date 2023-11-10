using MixedReality.Toolkit.UX;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{
    public PressableButton startButton, exitButton;
    public GameObject listRoom;
    
    private void Start()
    {
        startButton.OnClicked.AddListener(StartGame);
        exitButton.OnClicked.AddListener(ExitGame);
    }
    
    private void StartGame()
    {
        listRoom.SetActive(true);
        gameObject.SetActive(false);
    }
    
    private void ExitGame()
    {
        Application.Quit();
    }
}
