using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class previewNo : MonoBehaviour
{
    public GameObject open;
    public GameObject close;
    public PressableButton button;
    public static GameObject objects;

    private void Start()
    {
        button = GetComponent<PressableButton>();
        button.OnClicked.AddListener(preview);
    }

    private void preview()
    {
        open.SetActive(true);
        close.SetActive(false);
        if(objects != null)
        {
            Destroy(objects);
        }
    }
}
