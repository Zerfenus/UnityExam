using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger2 : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("GameField");
    }
}
