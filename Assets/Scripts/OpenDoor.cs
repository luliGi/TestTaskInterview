using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public GameObject door;
    public bool open = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player") && !open)
        {
            StopCoroutine(Close());
            StartCoroutine(Open());
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.CompareTag("Player") && open)
        {
            StopCoroutine(Open());
            StartCoroutine(Close());
            
        }
    }

    IEnumerator Open ()
    {
        float startRotation = door.transform.rotation.y;
        float t = startRotation;
        while (t < 75)
        {
            t += 1;
            door.transform.rotation = Quaternion.AngleAxis(t, Vector3.up);
            yield return null;
        }
        open = true;
    }

    IEnumerator Close ()
    {
        float startRotation = door.transform.rotation.y;
        float t = startRotation;
        while (t > 0)
        {
            t -= 1;
            door.transform.rotation = Quaternion.AngleAxis(t, Vector3.up);
            yield return null;
        }
        open = false;
    }
}
