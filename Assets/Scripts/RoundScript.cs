using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundScript : MonoBehaviour
{

    #region public var

    public bool startFinal;

    public GameObject finalRound;
    private GameManagerScript GMS;
    public Animator startRound;

    public List<GameObject> roundPlayerOne;
    public List<GameObject> roundPlayerTwo;

    public int numberOfRoundWinByPlayerOne;
    public int numberOfRoundWinByPlayerTwo;

    #endregion

    #region system

    private void Start()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        startRound = gameObject.GetComponent<Animator>();
    }

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

        if (numberOfRoundWinByPlayerOne > 3 && GMS.counterDownDone == true)
        {
            startRound.SetBool("startFinal", true);
        }

        if (numberOfRoundWinByPlayerTwo > 3 && GMS.counterDownDone == true)
        {
            startRound.SetBool("startFinal", true);
        }
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
