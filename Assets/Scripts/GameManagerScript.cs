using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{

    public Animator animCount;
    private GameManagerScript GMS;

    public bool countStart;
    public bool counterDownDone = false;

	void Start ()
    {
        animCount = gameObject.GetComponent<Animator>();
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }
	
	void Update ()
    {
        if (GMS.counterDownDone == true)
            animCount.SetBool("countStart", false);
    }
}
