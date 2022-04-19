using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    // Her loader vi næste scene
    // Denne metode kaldes fra Button scriptet
    public void GoToNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
