using MixedReality.Toolkit.UX;
using UnityEngine;

public class StyleMenuUI : MonoBehaviour
{
    public PressableButton Minimalism, Modern, Scandinavian, Loft, HighTech, Exit;
    public GameObject listRoom, scroll;
    public RoomType roomType;

    private void Start()
    {
        Minimalism.OnClicked.AddListener(() => OpenScroll(StyleType.Minimalism));
        Modern.OnClicked.AddListener(() => OpenScroll(StyleType.Modern));
        Scandinavian.OnClicked.AddListener(() => OpenScroll(StyleType.Scandinavian));
        Loft.OnClicked.AddListener(() => OpenScroll(StyleType.Loft));
        HighTech.OnClicked.AddListener(() => OpenScroll(StyleType.HighTech));

        Exit.OnClicked.AddListener(OpenListRoom);
    }

    private void OpenScroll(StyleType styleType)
    {
        gameObject.SetActive(false);
        
        scroll.SetActive(true);
        
        scroll.GetComponent<ScroolScreenUI>().SetUp(styleType, roomType);
    }

    private void OpenListRoom()
    {
        gameObject.SetActive(false);
        
        listRoom.SetActive(true);
    }
}