using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DifficultyScript : MonoBehaviour
{

    private TextMeshProUGUI textMesH;
    public int difficulty;
    private int diffIndex;

    // Start is called before the first frame update
    void Start()
    {
        
        textMesH = GetComponent<TextMeshProUGUI>();
        LoadPrefs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeDif()
    {
        diffIndex += 1;
        if (diffIndex > 2)
        {
            diffIndex = 0;
        }

        SetDif(diffIndex);
    }

    public void SetDif(int tDif)
    {
        difficulty = tDif;
        PlayerPrefs.SetInt("Difficulty", tDif);
        difficultyChanged();
    }

    public void difficultyChanged()
    {

        if (difficulty == 0)
        {
            

            textMesH.text = "Medium";

        }
        if (difficulty == 1)
        {
           

            textMesH.text = "Hard";
        }
        if (difficulty == 2)
        {
            

            textMesH.text = "Easy";

        }

        diffIndex = difficulty;

    }

    public void LoadPrefs()
    {
        difficulty = PlayerPrefs.GetInt("Difficulty");
        difficultyChanged();
    }

}
