using VVN.Utilities;

public static class VVNLog
{
    public static void Print(string msg, UnityEngine.Color color = default)
    {
#if VVNLOG_RELEASE_BUILD_ENABLE
        UnityEngine.Debug.Log($"<color={color.ToHexRGB(true)}>{msg}</color>");
#endif
    }
}