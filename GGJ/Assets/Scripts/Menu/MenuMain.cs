using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMain : MenuBase {
	public override void Hide() {
		canvasGroup.interactable = canvasGroup.blocksRaycasts = false;
		LeanTween.value(gameObject, canvasGroup.alpha, 0.0f, 0.2f)
		.setOnUpdate((float a) => {
			canvasGroup.alpha = a;
		}).setOnComplete(() => {
			gameObject.SetActive(false);
		});
		OnExit();
	}
}
