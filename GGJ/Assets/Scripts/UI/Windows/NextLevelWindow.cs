using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelWindow : BaseWindow {
	public Action onNextClick;

	public void OnNextLevelClick() {
		onNextClick?.Invoke();
		this.Close();
	}
}
