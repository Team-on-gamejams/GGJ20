using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public abstract class MenuBase : MonoBehaviour {
	[NonSerialized] public MenuManager MenuManager;

	protected CanvasGroup canvasGroup;

	protected virtual void Awake() {
		canvasGroup = GetComponent<CanvasGroup>();
	}

	public virtual void Show() {
		gameObject.SetActive(true);
		canvasGroup.interactable = canvasGroup.blocksRaycasts = true;
		canvasGroup.alpha = 1.0f;
		OnEnter();
	}

	public virtual void Hide() {
		canvasGroup.interactable = canvasGroup.blocksRaycasts = false;
		canvasGroup.alpha = 0.0f;
		OnExit();
		gameObject.SetActive(false);
	}

	protected virtual void OnEnter() { }
	protected virtual void OnExit() { }
}
