using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject ListRoom;
    public GameObject mainMenu;
    public PressableButton button;

    private void Start()
    {
        button = GetComponent<PressableButton>();
        button.OnClicked.AddListener(listRoom);
    }

    private void listRoom()
    {
        ListRoom.SetActive(true);
        mainMenu.SetActive(false);
    }


}
