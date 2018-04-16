using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundScript : MonoBehaviour
{

    #region public var

    public GameObject finalRound;

    public List<GameObject> roundPlayerOne;
    public List<GameObject> roundPlayerTwo;

    public int numberOfRoundWinByPlayerOne;
    public int numberOfRoundWinByPlayerTwo;

    #endregion

    #region system

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ActivateRoundIcon(roundPlayerOne, numberOfRoundWinByPlayerOne-1);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            ActivateRoundIcon(roundPlayerTwo, numberOfRoundWinByPlayerTwo - 1);
        }

        /*if (numberOfRoundWinByPlayerOne > 3 && )
        {

        }

        if (numberOfRoundWinByPlayerTwo > 3 && )
        {

        }*/
    }

    #endregion

    #region private function

    private void ActivateRoundIcon(List<GameObject> playerRound, int number)
    {
        for (int i = 0; i <= number; i++)
        {
            playerRound[i].SetActive(true);
        } 
        
    }

    #endregion

    #region private var
    #endregion

}
