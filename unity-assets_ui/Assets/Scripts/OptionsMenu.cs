using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    private int prevscene;

    public void Back()
    {
        prevscene = PlayerPrefs.GetInt("PrevScene");
        SceneManager.LoadSceneAsync(prevscene);
    }
}