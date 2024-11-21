using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BtnItemInventory : BtnAbstract
{
    [SerializeField] protected TextMeshProUGUI itemNameTxt;
    [SerializeField] protected TextMeshProUGUI itemCountTxt;

    [SerializeField] protected ItemInventory itemInventory;
    public ItemInventory ItemInventory => itemInventory;
    public override void OnClick()
    {
        //throw new System.NotImplementedException();
    }
    public virtual void SetItem(ItemInventory itemInventory)
    {
        this.itemInventory = itemInventory;
    }
    private void OnEnable()
    {
        this.itemNameTxt.text = this.itemInventory.GetItemName().ToString();
        this.itemCountTxt.text = this.itemInventory.itemCount.ToString();
    }
}
