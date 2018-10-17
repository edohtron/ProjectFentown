using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    [SerializeField] private Object GameScene;

    private SceneController sceneController;
    private bool inMainMenu;

	void Start () {

        inMainMenu = false;
	}
	
	void Update () {

        if (!inMainMenu) {
            inMainMenu = true;
        }
	}

    public void StartGame() {
        inMainMenu = false;
        SceneManager.LoadScene("GameScene");
    }
}
