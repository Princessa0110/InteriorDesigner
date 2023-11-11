using MixedReality.Toolkit.UX;
using UnityEngine;

public class ListRoomUI : MonoBehaviour
{
    public PressableButton Kitchen, Bedroom, LivingRoom, Cabinet, Bathroom, Exit;
    public GameObject mainMenu, styleMenu;

    private void Start()
    {
        Kitchen.OnClicked.AddListener(() => OpenStyleMenuRoom(RoomType.Kitchen));
        Bedroom.OnClicked.AddListener(() => OpenStyleMenuRoom(RoomType.Bedroom));
        LivingRoom.OnClicked.AddListener(() => OpenStyleMenuRoom(RoomType.LivingRoom));
        Cabinet.OnClicked.AddListener(() => OpenStyleMenuRoom(RoomType.Cabinet));
        Bathroom.OnClicked.AddListener(() => OpenStyleMenuRoom(RoomType.Bathroom));
        
        Exit.OnClicked.AddListener(OpenMainMenu);
        
        gameObject.SetActive(false);
    }

    private void OpenStyleMenuRoom(RoomType roomType)
    {
        styleMenu.GetComponent<StyleMenuUI>().roomType = roomType;

        styleMenu.SetActive(true);
        
        gameObject.SetActive(false);
    }
    
    private void OpenMainMenu()
    {
        gameObject.SetActive(false);
        
        mainMenu.SetActive(true);
    }
}