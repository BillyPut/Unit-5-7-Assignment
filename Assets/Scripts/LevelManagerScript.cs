using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagerScript : MonoBehaviour
{
    public string difficulty = "Easy";
    public Text difficultyText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        difficultyText.text = (difficulty);
    }

    public void difficultyChanged()
    {
        if (difficulty == "Easy")
        {
            difficulty = "Medium";
            
        }
        if (difficulty == "Medium")
        {
            difficulty = "Hard";
           
        }
        if (difficulty == "Hard")
        {
            difficulty = "Easy";
            
        }
    }


}
