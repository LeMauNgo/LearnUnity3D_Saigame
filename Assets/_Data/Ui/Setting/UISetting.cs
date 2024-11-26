using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISetting : MySingleton<UISetting>
{
    [SerializeField] protected bool isShow = true;
    protected bool IsShow => isShow;

    [SerializeField] protected Transform showHide;


    protected virtual void LateUpdate()
    {
        this.HotkeyToogleSetting();
    }

    private void Start()
    {
        this.Hide();
    }

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadShowHide();
    }

    protected virtual void LoadShowHide()
    {
        if (this.showHide != null) return;
        this.showHide = transform.Find("ShowHide");
        Debug.Log(transform.name + ": LoadShowHide", gameObject);
    }

    public virtual void Show()
    {
        this.isShow = true;
        this.showHide.gameObject.SetActive(this.isShow);
    }

    public virtual void Hide()
    {
        this.showHide.gameObject.SetActive(false);
        this.isShow = false;
    }

    public virtual void Toggle()
    {
        if (this.isShow) this.Hide();
        else this.Show();
    }

    protected virtual void HotkeyToogleSetting()
    {
        if (InputHotkeys.Instance.IsToogleSetting) this.Toggle();
    }
}

