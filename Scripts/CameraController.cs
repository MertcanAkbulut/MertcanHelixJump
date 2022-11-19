using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Fields
    [SerializeField] private Transform top;
    private Vector3 offset;

    [Header("De�i�kenler")]
    [SerializeField] private float speed = 0.05f;
    #endregion

    #region CameraMovement
    void Start()
    {
        offset = transform.position - top.position; //Bu fark� al�p top hareket etti�inde kameran�n do�ru �ekilde takip etmesini sa�layaca��z.
    }

    
    void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, top.position + offset, speed); //Lerp veya smoothDamp kullanarak kamera takibini daha ak�c� yap�yoruz.
        transform.position = newPos;
    }
    #endregion
}
