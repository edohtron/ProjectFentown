﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour {

    public GameObject pauseMenuInterface;

	// Use this for initialization
	void Start () {
        pauseMenuInterface.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!pauseMenuInterface.activeInHierarchy) {
                PauseGame();
            }

            else {
                UnpauseGame();
            }
        }
	}

    public void PauseGame() {
        pauseMenuInterface.SetActive(true);
    }

    public void UnpauseGame() {
        pauseMenuInterface.SetActive(false);
    }

}
