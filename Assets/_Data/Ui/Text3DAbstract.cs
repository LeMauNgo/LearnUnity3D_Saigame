using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Text3DAbstract : MyBehaviour
{
    [SerializeField] protected TextMeshPro textPro;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadTextPro();
    }

    protected virtual void LoadTextPro()
    {
        if (this.textPro != null) return;
        this.textPro = GetComponent<TextMeshPro>();
        Debug.Log(transform.name + ": LoadTextPro", gameObject);
    }
}
