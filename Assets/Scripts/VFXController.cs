using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

public class VFXController : MonoBehaviour
{
    [SerializeField] private VisualEffect vfx;
    private ExposedProperty _exposedPropertyBright;
    private ExposedProperty _exposedPropertyDark;

    [SerializeField, ColorUsageAttribute(true, true)] [OnValueChanged(nameof(OnBrightChange))]
    private Color brightColor;

    [SerializeField, ColorUsageAttribute(true, true)] [OnValueChanged(nameof(OnDarkChange))]
    private Color darkColor;

    private void Start()
    {
        _exposedPropertyBright = "BrightColor";
        _exposedPropertyDark = "DarkColor";
    }

    [Button]
    private void Play()
    {
        vfx.Play();
    }

    [Button]
    private void Pause()
    {
        vfx.pause = true;
    }

    [Button]
    private void Resume()
    {
        vfx.pause = false;
    }

    [Button]
    private void Stop()
    {
        vfx.Stop();
    }

    private void OnDarkChange()
    {
        vfx.SetVector4(_exposedPropertyDark, new Vector4(darkColor.r, darkColor.g, darkColor.b, 10));
    }

    private void OnBrightChange()
    {
        vfx.SetVector4(_exposedPropertyBright, new Vector4(brightColor.r, brightColor.g, brightColor.b, brightColor.a));
    }
}