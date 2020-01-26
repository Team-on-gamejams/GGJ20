using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGame : MenuBase {
	[SerializeField] CanvasGroup androidControlls;

	protected override void Awake() {
		base.Awake();
	}

	private void OnDestroy() {
	}


	protected override void OnEnter() {
		androidControlls.alpha = 1.0f;
	}

	protected override void OnExit() {
		base.OnExit();
		androidControlls.alpha = 0.0f;
	}
}
