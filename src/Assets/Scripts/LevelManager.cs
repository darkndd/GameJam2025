using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons; // Botones de los niveles

    void Start()
    {
        // Cargar el nivel desbloqueado más alto
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1); // Por defecto, solo el nivel 1 está desbloqueado

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                levelButtons[i].interactable = false; // Bloquea los niveles aún no desbloqueados
            }
        }
    }

    public void SelectLevel(string levelName)
    {
        SceneManager.LoadScene(levelName); // Carga la escena del nivel seleccionado
    }
}
