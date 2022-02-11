using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DifficultyScript : MonoBehaviour
{

    private TextMeshProUGUI textMesH;
    public string difficulty;

    // Start is called before the first frame update
    void Start()
    {
        
        textMesH = GetComponent<TextMeshProUGUI>();
        difficulty = "Easy";
        textMesH.text = "Easy";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void difficultyChanged()
    {

        if (difficulty == "Easy")
        {
            difficulty = "Medium";

            textMesH.text = "Medium";

        }
        else if (difficulty == "Medium")
        {
            difficulty = "Hard";

            textMesH.text = "Hard";
        }
        else
        {
            difficulty = "Easy";

            textMesH.text = "Easy";

        }

    }

}
