using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour {

    private string[] levelNames;

	// Use this for initialization
	void Start () {
        PopulateLevelNames();
        Init();
	}
	void Init()
    {
        Application.DontDestroyOnLoad(gameObject);
    }

    void PopulateLevelNames()
    {
        levelNames = new string[4];

        levelNames[0] = "MainMenu";
        levelNames[1] = "CavernOfSorrows";
        levelNames[2] = "CanyonOfRegret";
        levelNames[3] = "DesertOfTheTrumpVerse";
    }

    public void ChangeLevel (int value)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelNames[value]);
    }

	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("MainMenu");
        }
	}
}
