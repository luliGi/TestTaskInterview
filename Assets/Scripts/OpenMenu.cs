using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public GameObject menu;
    bool playerClose = false;
    //GameController GC;    

    // Start is called before the first frame update
    void Start()
    {
        //Invoke("CloseWindow", 1f);
        //GC = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerClose = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerClose = false;
            menu.SetActive(false);
        }
    }

    private void OnMouseDown()
    {
        if (playerClose)
        {
            menu.SetActive(true);            
        }
        //else
        //{
        //    Debug.Log("NOT CLOSE ENOUGH");
        //}        
    }

    public void CloseWindow()
    {
        menu.SetActive(false);
    }
}
