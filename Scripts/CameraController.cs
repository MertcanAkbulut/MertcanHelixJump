using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    #region Fields
    [SerializeField] private Transform top;
    private Vector3 offset;

    [Header("Deðiþkenler")]
    [SerializeField] private float speed = 0.05f;
    #endregion

    #region CameraMovement
    void Start()
    {
        offset = transform.position - top.position; //Bu farký alýp top hareket ettiðinde kameranýn doðru þekilde takip etmesini saðlayacaðýz.
    }

    
    void LateUpdate()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, top.position + offset, speed); //Lerp veya smoothDamp kullanarak kamera takibini daha akýcý yapýyoruz.
        transform.position = newPos;
    }
    #endregion
}
