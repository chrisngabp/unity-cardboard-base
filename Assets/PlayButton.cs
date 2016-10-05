using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PlayButton : MonoBehaviour, IPointerClickHandler {

	public void OnPointerClick(PointerEventData e) {
		GameObject objWithVideoTexture = GameObject.Find("sphere");
		MediaPlayerCtrl objVideoCtrl = (MediaPlayerCtrl) objWithVideoTexture.GetComponent(typeof(MediaPlayerCtrl));
		objVideoCtrl.UnLoad();
		objVideoCtrl.Load("prueba2.mp4");
	}
}
