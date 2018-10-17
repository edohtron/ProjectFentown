using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour {

    private SceneController _sceneController;
    private GameObject pauseMenuCanvas;

	// Use this for initialization
	void Start () {
        _sceneController = GameObject.Find("SCENECONTROLLER").GetComponent<SceneController>();
        pauseMenuCanvas = gameObject.transform.Find("PauseMenu").gameObject;
        pauseMenuCanvas.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
        if (!_sceneController) {
            _sceneController = GameObject.Find("SCENECONTROLLER").GetComponent<SceneController>();
        }

		if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!pauseMenuCanvas.activeInHierarchy) {
                pauseMenuCanvas.SetActive(true);
            }

            else {
                pauseMenuCanvas.SetActive(false);
            }
        }
       
	}

    void SetMainMenuScene() {
        SceneManager.LoadScene("MainMenuScene" , LoadSceneMode.Single);
    }
}
