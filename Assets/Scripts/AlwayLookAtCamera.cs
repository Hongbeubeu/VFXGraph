using UnityEngine;

[ExecuteInEditMode]
public class AlwayLookAtCamera : MonoBehaviour
{
    private void Update()
    {
        transform.forward = Camera.main.transform.forward;
    }
}