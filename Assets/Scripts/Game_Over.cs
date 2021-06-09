using UnityEngine;
using UnityEngine.SceneManagement;


public class Game_Over : MonoBehaviour
{
    public GameObject gameOverMenu;
    public void gameOver()
    {
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
    }
    public void restartGame()
    {
        SceneManager.LoadScene("MainGame");
    }
}
