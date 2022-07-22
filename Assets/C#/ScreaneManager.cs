using UnityEngine.SceneManagement;
using UnityEngine;

public class ScreaneManager : MonoBehaviour
{
    public void SceneChange(int _sceneNumber) 
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}
