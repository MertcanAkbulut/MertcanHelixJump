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
        //Y düzleminde top daireleri geçtiðinde daireler yok olacak ve bu sayede puan kazanacaðýz.
        if (transform.position.y+16f >= top.position.y)
        {
            Destroy(gameObject);
            GameManager.Instance.GameScore(25);
        }
    }
}
