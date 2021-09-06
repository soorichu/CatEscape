using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public GameObject hpGauge;
    public GameObject gameoverText;
    
    public void AddHp(float hp)
    {
        this.hpGauge.GetComponent<Image>().fillAmount += hp;
        if (this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            gameoverText.SetActive(true);
        }
    }
}
