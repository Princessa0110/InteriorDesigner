using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Exit : MonoBehaviour
{
    public PressableButton closeButton;

   public void Start()
    {
        closeButton.OnClicked.AddListener(ExitGame);
    }

   public void ExitGame()
    {
        Application.Quit();
    }
}
