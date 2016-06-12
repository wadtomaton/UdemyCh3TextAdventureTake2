using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MenuInputManager : MonoBehaviour {

	private LevelManager levelManager;

	private string currentSceneName = "";


	// Use this for initialization
	void Start () {
		GameObject go = GameObject.Find ("_LevelManager");
		levelManager = go.GetComponent<LevelManager>();

		currentSceneName = SceneManager.GetActiveScene().name;
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log (currentSceneName);

		if (currentSceneName == "WinLoseScreen") {
			if (Input.GetKeyDown("q")) {
				Debug.Log("quit pressed");
				levelManager.QuitRequest ();
			} else if (Input.GetKeyDown("t")) {
				levelManager.LoadLevel("Game");
			}
		} else if (currentSceneName == "MainMenu") {
			if (Input.GetKeyDown("space")) {
				levelManager.LoadLevel("Game");
			} else if (Input.GetKeyDown("q")) {
				Debug.Log("main quit pressed");
				levelManager.QuitRequest ();
			}
		}



	}
}
