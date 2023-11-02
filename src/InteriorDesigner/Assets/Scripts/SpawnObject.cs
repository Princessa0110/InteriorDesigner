using MixedReality.Toolkit;
using MixedReality.Toolkit.UX;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnObject : MonoBehaviour
{
    public GameObject SpawnObjects;
    private PressableButton spawnButton;
    
    void Start()
    {
        spawnButton = GetComponent <PressableButton>();
        spawnButton.OnClicked.AddListener(Spawn);
    }
    
    void Spawn()
    {
        Transform playerTransform = Camera.main.transform;

        Instantiate(SpawnObjects, playerTransform.position + playerTransform.forward * 4, Quaternion.identity);
    }
}
