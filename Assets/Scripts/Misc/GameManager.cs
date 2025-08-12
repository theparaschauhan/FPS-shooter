using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text enemiesLeftText;
    [SerializeField] GameObject youWinContainer;

    int enemiesLeft = 0;

    const string ENEMIES_LEFT_STRING = "Enemies Left: ";

    public void AdjustEnemiesLeft(int amount)
    {
        enemiesLeft += amount;
        enemiesLeftText.text = ENEMIES_LEFT_STRING + enemiesLeft.ToString();

        if (enemiesLeft <= 0)
        {
            youWinContainer.SetActive(true);
        }
    }






    public void RestartLevelButton()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene);
    }

    public void QuitButton()
    {
        Debug.Log("Quit Button will not Work in Editor");
        Application.Quit();
    }
}
