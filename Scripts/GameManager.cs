using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    #region Fields
    private int puan;
    [Header("Assetler")]
    [SerializeField] private TextMeshProUGUI puanText;
    [SerializeField] private GameObject kazanmaEkran�;
    #endregion


    #region Singleton
    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if(_instance==null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }
    #endregion

    #region UI
    //Daireleri ge�ti�imizde kazand���m�z puan� texte ge�iriyorum.
    public void GameScore(int dairePuan�)
    {
        puan += dairePuan�;
        puanText.text = puan.ToString();
    }

    //Son daireye ula�t���m�zda kazanma ekran� aktif hale geliyor.
    public void KazanmaEkran�()
    {
        kazanmaEkran�.SetActive(true);
    }
    #endregion

    #region Scene
    //Sonra ki sahneyi y�kl�yoruz.
    public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //K�rm�z� plartformlardan sonra sceneyi ba�tan ba�lat�yorum.
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //��k�� yap�yoruz.
    public void Quit()
    {
        Application.Quit();
    }
}
#endregion


