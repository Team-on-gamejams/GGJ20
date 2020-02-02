using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinWindow : BaseWindow {
	[SerializeField] SceneController sceneController;

	public void OnMenuClick() {
		sceneController.StartLoad(0);
	}
}
