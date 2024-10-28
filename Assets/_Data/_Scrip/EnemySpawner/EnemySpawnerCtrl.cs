using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerCtrl : MySingleton<EnemySpawnerCtrl>
{
    [SerializeField] protected EnemySpawner spawner;
    public EnemySpawner Spawner => spawner;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadSpawner();
    }
    protected virtual void LoadSpawner()
    {
        if (this.spawner != null) return;
        this.spawner = GetComponent<EnemySpawner>();
        Debug.LogWarning(gameObject.name + "LoadSpawner", gameObject);
    }
}
