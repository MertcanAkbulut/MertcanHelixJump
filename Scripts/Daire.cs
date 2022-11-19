using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daire : MonoBehaviour
{
    #region Fields
    [SerializeField] private Transform top;
    #endregion

    void Update()
    {
        //Y d�zleminde top daireleri ge�ti�inde daireler yok olacak ve bu sayede puan kazanaca��z.
        if (transform.position.y+16f >= top.position.y)
        {
            Destroy(gameObject);
            GameManager.Instance.GameScore(25);
        }
    }
}
