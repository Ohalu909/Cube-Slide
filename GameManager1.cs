using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager1 : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public void CompleteLevel ()
    {
        //(false) will disabled it,(true) will enabled it
        completeLevelUI.SetActive(true);
    }

    public GameObject completeLevelUI;


    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //restart game
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
