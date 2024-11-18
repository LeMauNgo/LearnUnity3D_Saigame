using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextAbstract : MyBehaviour
{
    [SerializeField] protected TextMeshProUGUI textPro;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadTextPro();
    }

    protected virtual void LoadTextPro()
    {
        if (this.textPro != null) return;
        this.textPro = GetComponent<TextMeshProUGUI>();
        Debug.Log(transform.name + ": LoadTextPro", gameObject);
    }
}
