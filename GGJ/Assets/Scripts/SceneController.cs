using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject loadingScreen;

	public Slider loadBar;
	
	public Text progressText;

	public int sceneID;

	public void StartLoad()
	{
		loadingScreen.SetActive(true);
		StartCoroutine(AsyncLoad());
	}

	public void StartLoad(int sceneID) {
		this.sceneID = sceneID;
		loadingScreen.SetActive(true);
		StartCoroutine(AsyncLoad());
	}

	IEnumerator AsyncLoad()
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);
		while (!operation.isDone)
		{
			float progress = operation.progress / .9f;
			loadBar.value = progress;
			progressText.text = string.Format("{0:0}%", progress * 100);
			yield return null;
		}
		
	}

	public void Exit(){
		Application.Quit();
	}
}
