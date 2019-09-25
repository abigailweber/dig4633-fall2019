using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManagementScript : MonoBehaviour
{
    // Start is called before the first frame update


    public bool chickenOne = false;
    public bool chickenTwo = false;
    public bool chickenThree = false;
    public bool chickenFour = false;
    public bool chickenFive = false;
    public bool pigOne = false;
    public bool pigTwo = false;
    public bool pigThree = false;
    public bool pigFour = false;
    public bool pigFive = false;

    public GameObject finishText;
    public GameObject startText;


    public void checkForVictory()
    {
        if (chickenOne && chickenTwo && chickenThree && chickenFour && chickenFive && pigOne && pigTwo && pigThree && pigFour && pigFive)
        {
            finishText.SetActive(true);
            startText.SetActive(false);
        }

    }

    public void chickenOneIn()
    {
        this.chickenOne = true;
        checkForVictory();
    }
    public void chickenTwoIn()
    {
        this.chickenTwo = true;
        checkForVictory();
    }
    public void chickenThreeIn()
    {
        this.chickenThree = true;
        checkForVictory();
    }
    public void chickenFourIn()
    {
        this.chickenFour = true;
        checkForVictory();
    }
    public void chickenFiveIn()
    {
        this.chickenFive = true;
        checkForVictory();
    }
    public void pigOneIn()
    {
        this.pigOne = true;
        checkForVictory();
    }
    public void pigTwoIn()
    {
        this.pigTwo = true;
        checkForVictory();
    }
    public void pigThreeIn()
    {
        this.pigThree = true;
        checkForVictory();
    }
    public void pigFourIn()
    {
        this.pigFour = true;
        checkForVictory();
    }
    public void pigFiveIn()
    {
        this.pigFive = true;
        checkForVictory();
    }

}


