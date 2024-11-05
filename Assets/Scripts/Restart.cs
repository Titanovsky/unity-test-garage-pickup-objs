using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] private string _scene = "GarageScene";

    private void RestartScene()
    {
        SceneManager.LoadScene(_scene);
    }

    private void CheckInputs()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
            RestartScene();
    }

    private void Update()
    {
        CheckInputs();
    }
}
