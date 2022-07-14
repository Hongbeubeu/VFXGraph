using System;
using DG.Tweening;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private Transform point;

    public Transform start;
    public Transform end;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnEffect();
        }
    }

    private void SpawnEffect()
    {
        point.transform.position = start.position;
        point.DOMove(end.position, 0.2f).SetEase(Ease.Linear);
    }
}