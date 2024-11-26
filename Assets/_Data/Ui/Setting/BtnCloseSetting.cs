using UnityEngine;

public class BtnCloseSetting : BtnAbstract
{
    public override void OnClick()
    {
        UISetting.Instance.Hide();
    }
}
