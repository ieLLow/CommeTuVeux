using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundScript : MonoBehaviour
{
    public Image round;
    public bool roundWin;
	
	void Update ()
    {
        if (roundWin == true)
            round.fillAmount = 1f;
        else
            round.fillAmount = 0f;
	}
}
