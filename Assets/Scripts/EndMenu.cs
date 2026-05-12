using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using static AllControl;

public class EndMenu : MonoBehaviour
{
    public void ReloadGame()
    {
        GameManager.Instance.totalscore = 0;
        GameManager.Instance.score = 0;

        EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex - 3);
    }

    // Start is called before the first frame update
    

    // Update is called once per frame
    
}
