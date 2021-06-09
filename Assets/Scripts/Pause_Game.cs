using UnityEngine;

public class Pause_Game : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetKeyDown(KeyCode.Escape)) return;

        if (isPaused)
            resume();
        else
            pause();
    }
    public void pause()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(!isPaused);
        isPaused = !isPaused;
    }
    public void resume()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(!isPaused);
        isPaused = !isPaused;
    }
    public void exitGame(){
        Application.Quit();
    }
}
