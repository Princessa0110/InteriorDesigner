using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class previewYes : MonoBehaviour
{
    public GameObject open;
    public GameObject close;
    public PressableButton button;

    private void Start()
    {
        button = GetComponent<PressableButton>();
        button.OnClicked.AddListener(preview);
    }

    private void preview()
    {
        open.SetActive(true);
        close.SetActive(false);
    }
}
