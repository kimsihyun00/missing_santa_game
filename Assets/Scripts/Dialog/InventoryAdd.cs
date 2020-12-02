using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAdd : MonoBehaviour
{
    public void RulerBtnClicked()
    {
        if (!CheckInventory((int)Items.RULERS))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.RULERS;
    }

    public void OldBookBtnClicked()
    {
        if (!CheckInventory((int)Items.OLD_BOOK))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.OLD_BOOK;
    }

    public void KioskBtnClicked()
    {
        if (!CheckInventory((int)Items.HAMBURGER))
            StartCoroutine(GetHamBurger());
    }

    public void SocksContractBtnClicked()
    {
        if (!CheckInventory((int)Items.CONTRACT4))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.CONTRACT4;
    }
    public void ButtonsBtnClicked()
    {
        if (!CheckInventory((int)Items.BUTTONS))
            Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.BUTTONS;
    }

    public bool CheckInventory(int itemNum)
    {
        bool HaveItem = false;
        for(int i=0; i<Inventory.InventoryItems.Length; i++)
        {
            if (Inventory.InventoryItems[i] == itemNum)
                HaveItem = true;
        }
        return HaveItem;
    }

    IEnumerator GetHamBurger()
    {
        yield return new WaitForSeconds(2f);
        Inventory.InventoryItems[Inventory.ItemNums++] = (int)Items.HAMBURGER;
    }
}

