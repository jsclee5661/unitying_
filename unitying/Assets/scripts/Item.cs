using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;

    private Inventory inventory;
    private bool isPlayerNearby = false;

    private void Start()
    {
        inventory = FindObjectOfType<Inventory>();
        if (inventory == null)
        {
            Debug.LogWarning("Inventory를 찾을 수 없습니다!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerNearby = true;
            Debug.Log("플레이어가 아이템에 가까워짐!");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isPlayerNearby = false;
            Debug.Log("플레이어가 아이템에서 멀어짐!");
        }
    }

    private void Update()
    {
        if (isPlayerNearby && Input.GetKeyDown(KeyCode.E))
        {
            PickupItem();
        }
    }

    private void PickupItem()
    {
        if (inventory != null)
        {
            inventory.AddItem(itemName, itemDescription, itemIcon);
            Debug.Log(itemName + " 획득!");

            // 대사창 띄우기
            DialogueManager dialogueManager = FindObjectOfType<DialogueManager>();
            if (dialogueManager != null)
            {
                dialogueManager.ShowDialogue(itemName + "를 얻었습니다!");
            }

            Destroy(gameObject);
        }
    }
}
