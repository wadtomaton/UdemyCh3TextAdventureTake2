using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float autoLoadNextLevel;
	private int sceneNum;

	void Start() {
		if (autoLoadNextLevel <= 0) {
			Debug.Log("No Level AutoLoad.");
		} else {
			Invoke ("LoadNextLevel", autoLoadNextLevel);
		}
	}

	public void LoadNextLevel() {
		//Application.LoadLevel(Application.loadedLevel + 1);
		getSceneNum();
		SceneManager.LoadScene (sceneNum + 1);
	}


	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	private void getSceneNum() {
		sceneNum = SceneManager.GetActiveScene().buildIndex;
	}

}
