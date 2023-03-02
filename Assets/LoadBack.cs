using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadBack : MonoBehaviour
{
    public void LoadSBack(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
