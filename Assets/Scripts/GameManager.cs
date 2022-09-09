using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public CanvasGroup startingPanel;

    // Start is called before the first frame update
    void Start()
    {
        startingPanel.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }
    }

    public void StartGame()
    {
        StartCoroutine(FadeUIGroup(startingPanel, 0, 3));
    }

    IEnumerator FadeUIGroup(CanvasGroup group, float endAlpha, float duration)
    {
        group.gameObject.SetActive(true);
        float startTime = Time.time;
        float startAlpha = group.alpha;
        float t = 0;
        while (Time.time < startTime + duration)
        {
            t += 1 / duration * Time.deltaTime; 
            group.alpha = Mathf.Lerp(startAlpha, endAlpha, t);
            yield return null;
        }
        group.gameObject.SetActive(false);
    }

    void QuitGame()
    {
        Application.Quit();
    }
}
