using System;
using UnityEngine;

namespace VVN.Utilities
{
    public static class ColorUtility
    {
        public static string ToHexRGB(this Color color, bool hasNumberSign = true)
        {
            Color32 color32 = new Color32((byte) Mathf.Clamp(Mathf.RoundToInt(color.r * (float) byte.MaxValue), 0, (int) byte.MaxValue), (byte) Mathf.Clamp(Mathf.RoundToInt(color.g * (float) byte.MaxValue), 0, (int) byte.MaxValue), (byte) Mathf.Clamp(Mathf.RoundToInt(color.b * (float) byte.MaxValue), 0, (int) byte.MaxValue), (byte) 1);
            return String.Format("{0}{1:X2}{2:X2}{3:X2}", (bool)(object) (hasNumberSign == true) ? "#" : "", color32.r, (object) color32.g, (object) color32.b);
        } 
    }
}
