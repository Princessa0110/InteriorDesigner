using MixedReality.Toolkit.UX;
using UnityEngine;

public class SpawnOrNoUI : MonoBehaviour
{
    public PressableButton yes, no;
    public GameObject scroolScreen, currentObject;
    public Transform contentTransform;

    private void Start()
    {
        yes.OnClicked.AddListener(Yes);
        
        no.OnClicked.AddListener(No);
        
        gameObject.SetActive(false);
    }

    private void No()
    {
        Destroy(currentObject);
        
        gameObject.SetActive(false);
        
        scroolScreen.SetActive(true);
    }

    private void Yes()
    {
        currentObject.transform.SetParent(null);
        
        currentObject = null;
        
        gameObject.SetActive(false);
        
        scroolScreen.SetActive(true);
    }
}