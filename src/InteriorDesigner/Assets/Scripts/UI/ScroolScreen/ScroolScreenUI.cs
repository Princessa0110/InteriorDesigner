using System.Collections.Generic;
using MixedReality.Toolkit.UX;
using UnityEngine;

public class ScroolScreenUI : MonoBehaviour
{
    public GameObject styleMenu, spawnOrNo;
    public GameObject buttonPrefab;
    public PressableButton exitButton;
    public Transform contentTransform;
    private List<GameObject> buttons = new();
    private ItemData[] itemDataArray;

    private void Start()
    {
        itemDataArray = Resources.LoadAll<ItemData>("Data");
            
        exitButton.OnClicked.AddListener(OpenStyleMenu);
        
        gameObject.SetActive(false);
    }

    public void SetUp(StyleType styleType, RoomType roomType)
    {
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
        
        buttons.Add(instance);
        
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

    private void OpenStyleMenu()
    {
        RemoveAllButton();
        
        gameObject.SetActive(false);
        
        styleMenu.SetActive(true);
    }
    
    private void RemoveAllButton()
    {
        while (buttons.Count > 0)
        {
            Destroy(buttons[0]);
           
            buttons.RemoveAt(0);
        }
    }
}