using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/Player Inventory Cannon Item Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCannonItemMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);
            Debug.Log("THIS CLASS IS PLAYER INVENTORY CANNON ITEM DATA");
        }
    }
}