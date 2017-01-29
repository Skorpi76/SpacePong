using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    public Button Play_Button;
    public Button Quit_Button;
	
    public void Play_Game()
    {
        SceneManager.LoadScene(1);
    }
    public void Play_Again_Multiplayer()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit_game()
    {
        Application.Quit();
    }
    public void Play_Multiplayer()
    {
        SceneManager.LoadScene(4);
    }
    public void Back_To_Menu()
    {
        SceneManager.LoadScene(0);
    }
}
