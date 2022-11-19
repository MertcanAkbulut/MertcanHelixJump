using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    #region Fields
    public Rigidbody topRB;
    [SerializeField] private GameObject splashPre;

    [Header("De�i�kenler")]
    [SerializeField] private float bounceForce = 6;
    #endregion

    #region Collisions
    private void OnCollisionEnter(Collision collision)
    {
        //Rigidbody componentini kullanarak devaml� z�plamas�n� sa�l�yorum.
        topRB.velocity = new Vector3(topRB.velocity.x, bounceForce, topRB.velocity.z);

        //Plartformlara temas etti�imizde bir splash efekti olu�acak.
        GameObject splash = Instantiate(splashPre, transform.position + new Vector3(0f, -0.2f,0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        //K�rm�z� plartformlara temas etti�imizde ba�a d�nece�iz.
        if(collision.gameObject.tag == "K�rm�z�")
        {
            GameManager.Instance.RestartGame();
        }
        //T�m daireleri ge�ip en sona ula�t���m�zda sonraki b�l�me ge�ece�iz.
        if(collision.gameObject.tag == "SonDaire")
        {
            GameManager.Instance.KazanmaEkran�();
        }
    }
    #endregion
}
