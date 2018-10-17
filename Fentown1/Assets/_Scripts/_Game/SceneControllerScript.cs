using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControllerScript : MonoBehaviour {

    private Scene currentScene;
    public string currentSceneName;

    public bool isGameActive = false;

    private void Awake() {
        DontDestroyOnLoad(this.gameObject);

        if (FindObjectsOfType(GetType()).Length > 1) {
            Destroy(this.gameObject);
        }
    }

    void Start() {
        currentScene = SceneManager.GetActiveScene();
        currentSceneName = currentScene.name;
    }

    // Update is called once per frame
    void Update() {
        if (currentScene != SceneManager.GetActiveScene()) {
            currentScene = SceneManager.GetActiveScene();
            currentSceneName = currentScene.name;
        }
    }


    public void SetGameScene() {
        SceneManager.LoadScene("01_GameScene" , LoadSceneMode.Single);
    }

    public void OptionsMenu() {
        SceneManager.LoadScene("01_GameScene" , LoadSceneMode.Single);
    }

    public void SetMainMenuScene() {
        SceneManager.LoadScene("00_MainMenuScene" , LoadSceneMode.Single);
    }


    public void ExitGame() {
        Application.Quit();
    }
}
