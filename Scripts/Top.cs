using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    #region Fields
    public Rigidbody topRB;
    [SerializeField] private GameObject splashPre;

    [Header("Deðiþkenler")]
    [SerializeField] private float bounceForce = 6;
    #endregion

    #region Collisions
    private void OnCollisionEnter(Collision collision)
    {
        //Rigidbody componentini kullanarak devamlý zýplamasýný saðlýyorum.
        topRB.velocity = new Vector3(topRB.velocity.x, bounceForce, topRB.velocity.z);

        //Plartformlara temas ettiðimizde bir splash efekti oluþacak.
        GameObject splash = Instantiate(splashPre, transform.position + new Vector3(0f, -0.2f,0f), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        //Kýrmýzý plartformlara temas ettiðimizde baþa döneceðiz.
        if(collision.gameObject.tag == "Kýrmýzý")
        {
            GameManager.Instance.RestartGame();
        }
        //Tüm daireleri geçip en sona ulaþtýðýmýzda sonraki bölüme geçeceðiz.
        if(collision.gameObject.tag == "SonDaire")
        {
            GameManager.Instance.KazanmaEkraný();
        }
    }
    #endregion
}
