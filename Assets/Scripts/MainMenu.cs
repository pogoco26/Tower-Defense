using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "LevelSelect";

	public void Play ()
	{
		SceneManager.LoadScene(levelToLoad);
	}

	public void Quit ()
	{
		Debug.Log("Exiting...");
		Application.Quit();
	}

}
