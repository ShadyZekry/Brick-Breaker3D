using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Over : MonoBehaviour
{
    public GameObject gameOverMenu;
    public void gameOver(string winner)
    {
        Time.timeScale = 0;
        gameOverMenu.SetActive(true);
        Text title = transform.GetChild(1).GetChild(1).gameObject.GetComponent<Text>();
        print(title.text);
        title.text = winner + " Player Wins";
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
}
