using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_script : MonoBehaviour {



	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void WorldScene() {
        SceneManager.LoadScene("01_WorldScene" , LoadSceneMode.Single);
    }

    public void OptionsMenu() {
        SceneManager.LoadScene("01_WorldScene" , LoadSceneMode.Single);
    }

    public void MainMenuScene() {
        SceneManager.LoadScene("00_MainMenu" , LoadSceneMode.Single);
    }

    public void LoadDemoBattleScene() {
        SceneManager.LoadScene("98_DemoBattleScene" , LoadSceneMode.Single);
    }

    public void QuitGame() {
        Application.Quit();
    }
}
