using System.Collections.Generic;
using MixedReality.Toolkit.UX;
using UnityEngine;

public class ScroolScreenUI : MonoBehaviour
{
    public GameObject styleMenu, spawnOrNo;
    public GameObject buttonPrefab;
    public PressableButton exitButton;
    public Transform contentTransform;
    public ItemData[] itemDataArray;
    private List<GameObject> buttons = new();

    private void Start()
    {
        exitButton.OnClicked.AddListener(OpenStyleMenu);
    }

    public void SetUp(StyleType styleType, RoomType roomType)
    {
        RemoveAllButton();

        foreach (var itemData in itemDataArray)
        {
            if (itemData.roomType == roomType && itemData.styleType == styleType)
            {
                CreatedCreatedButton(itemData);
            }
        }
    }

    private void CreatedCreatedButton(ItemData itemData)
    {
        var instance = Instantiate(buttonPrefab, contentTransform);
        
        var itemButtonUI = instance.GetComponent<ItemButtonUI>();
        
        itemButtonUI.textMeshProUGUI.text = itemData.name;
        
        itemButtonUI.buttonButton.OnClicked.AddListener(() => InstanceObject(itemData.prefab));
        
        instance.SetActive(true);
    }

    private void InstanceObject(GameObject prefab)
    {
        var spawnOrNoUI = spawnOrNo.GetComponent<SpawnOrNoUI>();
        
        spawnOrNoUI.currentObject = Instantiate(prefab, spawnOrNoUI.contentTransform);
        
        spawnOrNo.SetActive(true);
        
        gameObject.SetActive(false);
    }

    private void RemoveAllButton()
    {
        while (buttons.Count > 0)
        {
            Destroy(buttons[0]);
           
            buttons.RemoveAt(0);
        }
    }

    private void OpenStyleMenu()
    {
        gameObject.SetActive(false);
        
        styleMenu.SetActive(true);
    }
}