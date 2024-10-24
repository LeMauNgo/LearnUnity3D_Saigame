using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CapsuleCollider))]
public class EnemyDamageReceiver : DamageReceiver
{
    [SerializeField] protected CapsuleCollider capsuleCollider;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCapsuleCollider();
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
        //throw new System.NotImplementedException();
    }

    protected override void OnHurt()
    {
        //throw new System.NotImplementedException();
    }
}
