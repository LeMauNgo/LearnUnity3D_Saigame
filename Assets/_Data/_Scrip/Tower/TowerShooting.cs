using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : TowerAbstract
{
    [SerializeField] protected EnemyCtrl target;
    private void Update()
    {
        this.GetTarget();
        this.LookAtTarget();
        this.Shooting();
    }
    protected virtual void GetTarget()
    {
        this.target = towerCtrl.TowerRada.GetEnemy();
    }
    protected virtual void LookAtTarget()
    {
        if (this.target == null) return;
        this.towerCtrl.Rotator.LookAt(this.target.transform.position);
    }
    protected virtual void Shooting()
    {
        EffectSpawner.Instance.SpawnBullet();
    }
}
