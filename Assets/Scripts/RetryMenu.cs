using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RetryMenu : MonoBehaviour
{

    public bool isDead = false;
    public GameObject retryMenu;
    public float timeLeft = 5f;

    void Start ()
    {
        

    }

    void Update ()
    {
        if (isDead == true)
        {
            retryMenu.SetActive(true);
            timeLeft -= Time.deltaTime;

            if (timeLeft < 0)
                SceneManager.LoadScene("Menu");
        }
        else
        {
            retryMenu.SetActive(false);
        }
    }
}
