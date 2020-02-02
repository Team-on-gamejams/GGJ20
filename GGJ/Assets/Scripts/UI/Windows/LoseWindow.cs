using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseWindow : BaseWindow {
	[SerializeField] SceneController sceneController;

	public void OnMenuClick() {
		sceneController.StartLoad(0);
	}

	public void OnRestartClick() {
		sceneController.StartLoad(1);
	}
}
