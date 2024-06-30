using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    public int targetSceneIndex;
    public string scenename;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(scenename);
        }
        // check whether the object has the "player" tag
        if (other.tag == "Player");
        {
            // if it is player, change scene
            ChangeScene();
        }
    }
      
    public void ChangeScene()
    {
        SceneManager.LoadScene(targetSceneIndex);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
