using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider))]
public class Targetable : MyBehaviour
{
    [SerializeField] protected CapsuleCollider _capsuleCollider;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCollider();
    }
    protected virtual void LoadCollider()
    {
        if (this._capsuleCollider != null) return;
        this._capsuleCollider = transform.GetComponent<CapsuleCollider>();
        this._capsuleCollider.radius = 0.3f;
        this._capsuleCollider.height = 2;
        this._capsuleCollider.center = new Vector3(0,1,0);
        Debug.LogWarning(gameObject.name + "Load Collider", gameObject);
    }
}
