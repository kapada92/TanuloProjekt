using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject panel;

    public void New_Game()
    {
        SceneManager.LoadScene(1); 
    }

    public void Save()
    {

    }

    public void Load()
    {
        
    }

    public void Settings()
    {

    }

    public void Kilepes()
    {
        Application.Quit();
    }

    public void Continut()
    {
        panel.SetActive(false);
    }

    public void menu()
    {
        SceneManager.LoadScene(0);
    }
}
