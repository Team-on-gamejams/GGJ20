using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeanMover : MonoBehaviour
{
    const float speed = 750f;

    public static LeanMover Instance;

    [SerializeField] Canvas canvas;

    private void Awake() {
        Instance = this;
    }

    public void Move(GameObject gameObject, Vector3 pos) {
        Transform finalParent = gameObject.transform.parent;
        gameObject.transform.SetParent(canvas.transform);
        LeanTween.cancel(gameObject, false);
		LeanTween.move(gameObject, pos, (gameObject.transform.position - pos).magnitude / speed)
            .setOnComplete(()=> {
                gameObject.transform.SetParent(finalParent);
            });
    }
}
