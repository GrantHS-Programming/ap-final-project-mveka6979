using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayButton : MonoBehaviour
{

    public void PlayButtonGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

}
