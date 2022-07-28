using System;
using Sirenix.OdinInspector;
using UnityEngine;

public class DissolveControl : MonoBehaviour
{
    [SerializeField] private MeshRenderer mainMesh;

    private bool isDissolve;
    private bool isUnDissolve;
    private float x;
    public Material _material;
    private static readonly int Dissolve1 = Shader.PropertyToID("_Dissolve");

    [Button]
    public void Dissolve()
    {
        x = 0;
        isDissolve = true;
    }

    [Button]
    public void UnDissolve()
    {
        x = 1;
        isUnDissolve = true;
    }

    private void Start()
    {
        _material = mainMesh.material;
    }

    private void Update()
    {
        if (isDissolve)
        {
            x += Time.deltaTime;
            if (x >= 1)
            {
                x = 1;
                isDissolve = false;
            }

            _material.SetFloat(Dissolve1, x);
        }

        if (isUnDissolve)
        {
            x -= Time.deltaTime;
            if (x < 0)
            {
                x = 0;
                isUnDissolve = false;
            }

            _material.SetFloat(Dissolve1, x);
        }
    }
}