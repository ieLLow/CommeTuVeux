using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour
{
    private GameManagerScript GMS;
    public Animator countDownAnim;

    public void SetCountDownNow()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.counterDownDone = true;
    }

    public void Update()
    {
        
    }

}
