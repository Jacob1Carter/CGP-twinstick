using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    [SerializeField] private GameObject[] uiElements;
    public void OpenLevel(int levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ShowElement(GameObject objectToShow)
    {
        ToggleInactive();
        objectToShow.SetActive(true);
    }

    private void ToggleInactive()
    {
        for (int i=0; i<uiElements.Length; i++)
        {
            uiElements[i].SetActive(false);
        }
    }
}
