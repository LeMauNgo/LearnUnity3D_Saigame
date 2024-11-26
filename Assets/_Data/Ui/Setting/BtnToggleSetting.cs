using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnToggleSetting : BtnAbstract
{
    public override void OnClick()
    {
        UISetting.Instance.Toggle();
    }
}
