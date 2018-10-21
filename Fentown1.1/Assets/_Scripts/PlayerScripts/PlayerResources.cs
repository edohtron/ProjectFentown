using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerResources : MonoBehaviour {

    // standard resource
    static private int Gold = 100; 
    static private int Stone = 20;
    static private int Lumber = 50;
    static private int Food = 90;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space)) {
            AdjustGold(10);

            Debug.Log(Gold);
        }


	}

    public void AdjustGold(int val) {
        Gold += val;
    }

    public void AdjustStone(int val) {
        Stone += val;
    }

    public void AdjustLumber(int val) {
        Lumber += val;
    }

    public void AdjustFood(int val) {
        Food += val;
    }

    public void CalculateFinance() {

    }
}
