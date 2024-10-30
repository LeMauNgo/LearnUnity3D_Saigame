using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider))]
public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected CapsuleCollider capsuleCollider;
    [SerializeField] protected EnemyCtrl ctrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCapsuleCollider();
        this.LoadEnemyCtrl();
    }
    protected virtual void LoadEnemyCtrl()
    {
        if (this.ctrl != null) ;
        this.ctrl = GetComponentInParent<EnemyCtrl>();
        Debug.Log(gameObject.name + "LoadEnemyCtrl", gameObject);
    }
    protected virtual void LoadCapsuleCollider()
    {
        if (this.capsuleCollider != null) return;
        this.capsuleCollider = transform.GetComponent<CapsuleCollider>();
        this.capsuleCollider.radius = 0.3f;
        this.capsuleCollider.height = 2;
        this.capsuleCollider.center = new Vector3(0, 1, 0);
        Debug.LogWarning(gameObject.name + "LoadCapsuleCollider", gameObject);
    }
    protected override void OnDead()
    {
        this.ctrl.Despawn.DoDespawn();
    }

    protected override void OnHurt()
    {
        //throw new System.NotImplementedException();
    }
}
