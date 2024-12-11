using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingRightHand_hint : MyBehaviour
{
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.ResetValue();
    }

    protected virtual void ResetValue()
    {
        transform.localPosition = new Vector3(4.33f, -1.19f, 3.02f);
        transform.localRotation = Quaternion.Euler(0, 0, 0);
    }
}
