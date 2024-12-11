using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingRightHand_target : MyBehaviour
{
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.ResetValue();

    }
    protected virtual void ResetValue()
    {
        transform.localPosition = new Vector3(1.79f, 3.48f, 5.05f);
        transform.localRotation = Quaternion.Euler(new Vector3(-8.847f, -98.795f, -79.018f));
    }
}
