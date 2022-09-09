using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PriceController : MonoBehaviour
{
    public float price;
    public bool selected = false;
    public GameObject frame;

    // Start is called before the first frame update
    void Start()
    {
        string s = transform.GetChild(0).GetComponent<TextMeshProUGUI>().text.ToString();
        price = float.Parse(s);
    }

    public void SelectOption()
    {
        if (selected)
        {
            frame.SetActive(false);
            selected = false;
        }
        else
        {
            frame.SetActive(true);
            selected = true;
        }
    }
}
