using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManagerScript : MonoBehaviour
{
    
    string scene;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

        scene = SceneManager.GetActiveScene().name;

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            if (scene == "Scene2")
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

    }

    

   
}
