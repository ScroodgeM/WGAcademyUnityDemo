using UnityEngine;

public class CameraFollow2DLerpSmooth : MonoBehaviour
{
    [SerializeField] private Vector3 cameraOffset;
    [SerializeField] private Transform target;
    [SerializeField] private float followSpeed;

    private void LateUpdate()
    {
        Vector3 oldPos = transform.position;
        Vector3 newPos = target.position + cameraOffset;
        float lerp = Time.deltaTime * followSpeed;

        transform.position = Vector3.Lerp(oldPos, newPos, lerp);
    }
}
