using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{  
   public Ball ball;

   public Text playerText;
   public Text computerText;
   private int playerScore;

   private int computerScore;

   public void PlayerScores()
   {
        playerScore++;

        this.playerText.text = playerScore.ToString();

   }

   public void ComputerScores()
   {
        computerScore++;

        this.computerText.text = computerScore.ToString();

        
   }



}


