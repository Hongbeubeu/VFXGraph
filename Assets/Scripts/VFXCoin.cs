using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.VFX;

public class VFXCoin : MonoBehaviour
{
    public VisualEffect vfx;
    int eventName = Shader.PropertyToID("Play");

    [Button]
    public void StartEvent()
    {
        vfx.SendEvent(eventName);
    }
}