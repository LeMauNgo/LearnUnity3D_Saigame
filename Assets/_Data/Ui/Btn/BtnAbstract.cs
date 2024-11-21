using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public abstract class BtnAbstract : MyBehaviour
{
    [SerializeField] protected Button button;

    private void Start()
    {
        this.AddOnClickEvent();
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadButton();
    }

    protected virtual void LoadButton()
    {
        if (this.button != null) return;
        this.button = GetComponent<Button>();
        Debug.Log(transform.name + ": LoadButton", gameObject);
    }

    protected virtual void AddOnClickEvent()
    {
        this.button.onClick.AddListener(this.OnClick);
    }

    public abstract void OnClick();
}
