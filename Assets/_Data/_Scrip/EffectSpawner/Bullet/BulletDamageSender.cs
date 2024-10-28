using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SphereCollider))]
public class BulletDamageSender : DamageSender
{
    [SerializeField] protected SphereCollider sphereCollider;
    [SerializeField] protected BulletCtrl bulletCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadBulletCtrl();
    }
    protected virtual void LoadBulletCtrl()
    {
        if (this.bulletCtrl != null) return;
        this.bulletCtrl = GetComponentInParent<BulletCtrl>();
        Debug.Log(gameObject.name + "LoadBulletCtrl", gameObject);
    }
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
        DamageReceiver damageReceiver = base.SendDamage(collider);
        if (damageReceiver == null) return null;
        this.bulletCtrl.Despawn.DoDespawn();
        return damageReceiver;
    }
}
