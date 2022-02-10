using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManagerScript : MonoBehaviour
{
    public GameObject startButton;
    

    // Start is called before the first frame update
    void Start()
    {
        startButton.GetComponent<Button>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartButtonPressed()
    {
        SceneManager.LoadScene("Scene2");
    }

    public void QuitGame()
    {
        Application.Quit();
    }




}
