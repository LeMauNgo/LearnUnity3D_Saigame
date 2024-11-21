using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnToggleInventory : BtnAbstract
{
    public override void OnClick()
    {
        UiInventory.Instance.Toggle();
    }
}
