using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManagerScript : MonoBehaviour
{
    public string difficulty;
    //public Text difficultyText;
    string scene;
    

    // Start is called before the first frame update
    void Start()
    {
        difficulty = "Easy";
    }

    // Update is called once per frame
    void Update()
    {
        //difficultyText.text = (difficulty);

        scene = SceneManager.GetActiveScene().name;

        if (Input.GetKeyDown("l"))
        {
            if (scene == "Scene2")
            {
                SceneManager.LoadScene("SampleScene");
            }
        }

    }

    public void difficultyChanged()
    {
        if (difficulty == "Easy")
        {
            difficulty = "Medium";
            
            
        }
        else if  (difficulty == "Medium")
        {
            difficulty = "Hard";
           
        }
        else
        {
            difficulty = "Easy";
            
        }

    }

   
}
