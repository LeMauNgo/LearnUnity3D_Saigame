using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;
using UnityEngine.EventSystems;

public class EffectSpawnerCtrl : MySingleton<EffectSpawnerCtrl>
{
    [SerializeField] protected EffectSpawner spawner;
    public EffectSpawner Spawner => spawner;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadSpawner();
    }
    protected virtual void LoadSpawner()
    {
        if (this.spawner != null) return;
        this.spawner = GetComponent<EffectSpawner>();
        Debug.LogWarning(gameObject.name + "LoadSpawner", gameObject);
    }
}
