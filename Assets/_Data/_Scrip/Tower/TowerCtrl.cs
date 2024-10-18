using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TowerCtrl : MyBehaviour
{
    [SerializeField] protected TowerRada towerRada;
    public TowerRada TowerRada => towerRada;
    [SerializeField] protected Transform rotator;
    public Transform Rotator => rotator;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadTowerRada();
        this.LoadRotator();
    }
    protected virtual void LoadTowerRada()
    {
        if (this.towerRada != null) return;
        this.towerRada = GetComponentInChildren<TowerRada>();
        Debug.LogWarning(gameObject.name + "LoadTowerRada", gameObject);
    }
    protected virtual void LoadRotator()
    {
        if(this.rotator != null) return;
        this.rotator = transform.Find("Model").Find("Rotator");
        Debug.LogWarning(gameObject.name + "LoadRotator", gameObject);
    }
}
