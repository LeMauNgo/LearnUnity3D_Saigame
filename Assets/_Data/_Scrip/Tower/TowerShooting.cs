using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShooting : TowerAbstract
{
    [SerializeField] protected EffectCtrl bullet;
    [SerializeField] protected EnemyCtrl target;
    [SerializeField] protected float timer;
    [SerializeField] protected int delay = 1;
    [SerializeField] protected List<FirePoint> firePoints;
    private void Update()
    {
        this.GetTarget();
        this.LookAtTarget();
        this.Shooting();
    }
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadFirePoint();
    }
    protected virtual void LoadFirePoint()
    {
        if (this.firePoints.Count > 0) return;
        FirePoint[] firePoints = this.towerCtrl.GetComponentsInChildren<FirePoint>();
        this.firePoints = new List<FirePoint>(firePoints);
        Debug.LogWarning(transform.name + "Load FirePoint", gameObject);
    }
    protected virtual FirePoint GetFirePoint()
    {
        int pointIndex = Random.Range(0, firePoints.Count);
        return firePoints[pointIndex];
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
        if (this.target == null) return;
        this.timer += Time.deltaTime;
        if (this.timer < this.delay) return;
        EffectCtrl bulletPbs = EffectSpawnerCtrl.Instance.Spawner.Spawn(this.bullet, GetFirePoint().transform.position, this.firePoints[0].transform.rotation);
        this.timer = 0;
        bulletPbs.gameObject.SetActive(true);
    }
}
