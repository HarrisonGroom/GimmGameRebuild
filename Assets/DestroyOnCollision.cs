using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other) {
        Destroy (gameObject);
        Destroy (other.gameObject);
        gameManager.UpdateScore(5);   

    }
    /*
private void OnTriggerEnter(Collider other) {
    Destroy (gameObject);
    Destroy (other.gameObject);
            ScoreManager.score++; //Increment the display score by 1
            scoreUI.text = displayScore.ToString(); 
}
*/
      
  

}