using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class BulletDamageSender : DamageSender
{
    [SerializeField] protected SphereCollider sphereCollider;
    protected override void LoadTriggerCollider()
    {
        if (this._collider != null) return;
        this._collider = GetComponent<Collider>();
        this.sphereCollider = (SphereCollider)this._collider;
        this._collider.isTrigger = true;
        this.sphereCollider.radius = 0.5f;
        Debug.Log(transform.name + ": LoadTriggerCollider", gameObject);
    }
    protected override DamageReceiver SendDamage(Collider collider)
    {
        return base.SendDamage(collider);
    }
}
