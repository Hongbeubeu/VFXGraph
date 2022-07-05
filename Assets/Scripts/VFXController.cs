using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

public class VFXController : MonoBehaviour
{
    [SerializeField] private VisualEffect vfx;
    private ExposedProperty _exposedPropertyBright;
    private ExposedProperty _exposedPropertyDark;

    [SerializeField, ColorUsageAttribute(true, true)]
    private Color brightColor;

    [SerializeField, ColorUsageAttribute(true, true)]
    private Color darkColor;

    private void Start()
    {
        _exposedPropertyBright = "BrightColor";
        _exposedPropertyDark = "DarkColor";
    }

    [Button]
    private void Play()
    {
        vfx.SetVector4(_exposedPropertyBright, new Vector4(brightColor.r, brightColor.g, brightColor.b, brightColor.a));
        vfx.SetVector4(_exposedPropertyDark, new Vector4(darkColor.r, darkColor.g, darkColor.b, darkColor.a));

        vfx.Play();
    }
}