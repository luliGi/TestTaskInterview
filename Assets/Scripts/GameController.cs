using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public TextMeshProUGUI t_money_TMP;
    public Image i_money;
    public float n_money;

    

    // Start is called before the first frame update
    void Start()
    {
        UpdateCash();        
    }

    public void UpdateCash()
    {
        t_money_TMP.text = n_money.ToString();
    }

}
