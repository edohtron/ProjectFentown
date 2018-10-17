using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

    public Scene currentScene;
    public string currentSceneName;

    public bool isGameActive = false;

    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this.gameObject);
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentScene != SceneManager.GetActiveScene()) {
            currentScene = SceneManager.GetActiveScene();
            currentSceneName = currentScene.name;
        }
	}


    public void SetGameScene() {
        SceneManager.LoadScene("GameScene" , LoadSceneMode.Single);
    }

    public void OptionsMenu() {
        SceneManager.LoadScene("GameScene" , LoadSceneMode.Single);
    }

    public void SetMainMenuScene() {
        SceneManager.LoadScene("MainMenuScene" , LoadSceneMode.Single);
    }


    public void ExitGame() {
        // CLOSE APPLICATION!
    }
}
