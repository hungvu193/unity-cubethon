using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

   private bool isGameEnded = false;
   public GameObject completeLevelUI;

   public void EndGame()
    {
        if (isGameEnded == false)
        {
            isGameEnded = true;
            Debug.Log("Game Over");
            Invoke("RestartGame", 2f);
        }
    }


    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void CompleteLevel()
    {
        Debug.Log("Level Won");
        completeLevelUI.SetActive(true);
    }
    
}
