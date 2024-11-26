using UnityEngine;

public class BtnExitGame : BtnAbstract
{
    public override void OnClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
