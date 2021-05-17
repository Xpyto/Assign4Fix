using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public GameOverScript gameOver;
    public GameOverScript gameWon;
    public PlayerMovement player;

    public void GameOver(){
        gameOver.Setup();
    }

    private void Update() {
        if(player.isDead){
            GameOver();
        }

        if(player.isWon){
            gameWon.Setup();
        }
    }


}
