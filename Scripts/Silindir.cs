using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Silindir : MonoBehaviour
{
    #region Fields
    [SerializeField] private float donmeHýzý = 30f;
    #endregion

    #region PlayerMovement
    void Update()
    {
        //Silindiri touch inputun horizontal pozisyonuna göre döndürüyorum.
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Touch screenTouch = Input.GetTouch(0);
            transform.Rotate(0f, -screenTouch.deltaPosition.x * donmeHýzý * Time.deltaTime, 0f);

        }
    }
    #endregion
}
