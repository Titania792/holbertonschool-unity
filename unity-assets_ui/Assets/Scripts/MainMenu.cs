using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int currentscene;

    //
    public void LevelSelect(int level)
    {
        if (level == 1)
        {
            SceneManager.LoadScene("Level01");
        }
        if (level == 2)
        {
            SceneManager.LoadScene(3);
        }
        if (level == 3)
        {
            SceneManager.LoadScene(4);
        }
    }
    // script OptionsButton so that clicking on it loads the Options scene
    public void Options()
    {
        currentscene = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("PrevScene", currentscene);
        SceneManager.LoadScene(4);
    }
    //script the ExitButton so that when it is clicked, the game is closed and Exited is printed to the console
    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
