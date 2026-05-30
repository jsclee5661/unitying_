using UnityEngine;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    // 아이템 정보를 저장할 클래스
    [System.Serializable]
    public class InventoryItem
    {
        public string itemName;
        public string itemDescription;
        public Sprite itemIcon;

        public InventoryItem(string name, string description, Sprite icon)
        {
            itemName = name;
            itemDescription = description;
            itemIcon = icon;
        }
    }

    private List<InventoryItem> items = new List<InventoryItem>(); // 보유한 아이템 목록

    // 아이템 추가
    public void AddItem(string name, string description, Sprite icon)
    {
        items.Add(new InventoryItem(name, description, icon));
        Debug.Log($"'{name}' 아이템을 얻었습니다!");
    }

    // 아이템 제거
    public void RemoveItem(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    // 아이템 목록 반환 (UI에서 사용)
    public List<InventoryItem> GetItems()
    {
        return items;
    }

    // 아이템 개수 반환
    public int GetItemCount()
    {
        return items.Count;
    }
}
