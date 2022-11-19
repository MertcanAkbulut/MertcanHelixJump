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
    [SerializeField] private GameObject kazanmaEkraný;
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
    //Daireleri geçtiðimizde kazandýðýmýz puaný texte geçiriyorum.
    public void GameScore(int dairePuaný)
    {
        puan += dairePuaný;
        puanText.text = puan.ToString();
    }

    //Son daireye ulaþtýðýmýzda kazanma ekraný aktif hale geliyor.
    public void KazanmaEkraný()
    {
        kazanmaEkraný.SetActive(true);
    }
    #endregion

    #region Scene
    //Sonra ki sahneyi yüklüyoruz.
    public void SonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Kýrmýzý plartformlardan sonra sceneyi baþtan baþlatýyorum.
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    //Çýkýþ yapýyoruz.
    public void Quit()
    {
        Application.Quit();
    }
}
#endregion


