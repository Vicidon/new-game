using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartScript : MonoBehaviour
{
  //Restart the set scene.
    public void restartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

}


