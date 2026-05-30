using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("문을 열기 위한 아이템 이름")]
    public string requiredItemName = "Key";

    [Header("문 열릴 때 비활성화할 오브젝트")]
    public GameObject doorBlock;

    private bool isOpen = false;

    public bool CanUseItem(string itemName)
    {
        return !isOpen && itemName == requiredItemName;
    }

    public void UseItem(string itemName)
    {
        if (isOpen)
            return;

        if (itemName == requiredItemName)
        {
            OpenDoor();
        }
        else
        {
            Debug.Log("이 아이템으로는 문을 열 수 없습니다.");
        }
    }

    private void OpenDoor()
    {
        isOpen = true;
        Debug.Log("문이 열렸습니다!");

        if (doorBlock != null)
        {
            doorBlock.SetActive(false);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
