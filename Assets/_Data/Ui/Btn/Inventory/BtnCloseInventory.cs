using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnCloseInventory : BtnAbstract
{
    [SerializeField] protected UiInventory uiInventory;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadUiInventory();
    }
    protected virtual void LoadUiInventory()
    {
        if (this.uiInventory != null) return;
        this.uiInventory = GetComponentInParent<UiInventory>();
        Debug.Log(gameObject.name + "LoadUiInventory", gameObject);
    }
    public override void OnClick()
    {
        this.uiInventory.Hide();
    }
}
