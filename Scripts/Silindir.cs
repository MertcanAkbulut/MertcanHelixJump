using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silindir : MonoBehaviour
{
    #region Fields
    [SerializeField] private float donmeH�z� = 30f;
    #endregion

    #region PlayerMovement
    void Update()
    {
        //Silindiri touch inputun horizontal pozisyonuna g�re d�nd�r�yorum.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Touch screenTouch = Input.GetTouch(0);
            transform.Rotate(0f, -screenTouch.deltaPosition.x * donmeH�z� * Time.deltaTime, 0f);

        }
    }
    #endregion
}
