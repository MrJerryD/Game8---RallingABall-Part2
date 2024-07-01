using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Цель, за которой следует камера
    public Vector3 offset; // Отступ камеры от цели

    private void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset; // Устанавливаем позицию камеры над целью
        }
    }
}
