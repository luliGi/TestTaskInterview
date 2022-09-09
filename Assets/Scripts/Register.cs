using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Register : MonoBehaviour
{
    GameController GC;
    public GameObject [] itemsToBuyArray;
    public GameObject[] itemsToSellArray;
    public GameObject[] itemsToWearArray;    

    // Start is called before the first frame update
    void Start()
    {
        GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        //itemsToBuyArray = GameObject.FindGameObjectsWithTag("ToBuy");
        //itemsToSellArray = GameObject.FindGameObjectsWithTag("ToSell");
        //itemsToWearArray = GameObject.FindGameObjectsWithTag("ToWear");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void BuyItems()
    {
        int i = 0;
        foreach (GameObject go in itemsToBuyArray)
        {
            i++;
            if (go.GetComponent<PriceController>().selected && GC.n_money >= go.GetComponent<PriceController>().price)
            {
                GC.n_money = GC.n_money - go.GetComponent<PriceController>().price;
                GC.t_money_TMP.text = GC.n_money.ToString();
                go.GetComponent<PriceController>().SelectOption();
                go.GetComponent<Button>().interactable = false;
                itemsToSellArray[i - 1].GetComponent<Button>().interactable = true;
                itemsToWearArray[i - 1].GetComponent<Button>().interactable = true;
            }
            //else
            //{
            //    Debug.Log("NOT ENOUGH MONEY");
            //}
        }
    }

    public void SellItems()
    {
        int i = 0;
        foreach (GameObject go in itemsToSellArray)
        {
            i++;
            if (go.GetComponent<PriceController>().selected)
            {
                GC.n_money = GC.n_money + go.GetComponent<PriceController>().price;
                GC.t_money_TMP.text = GC.n_money.ToString();
                go.GetComponent<PriceController>().SelectOption();
                go.GetComponent<Button>().interactable = false;
                itemsToBuyArray[i - 1].GetComponent<Button>().interactable = true;
                itemsToWearArray[i - 1].GetComponent<Button>().interactable = false;
            }            
        }
    }
}
