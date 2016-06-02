using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardboardButton : MonoBehaviour, IPointerClickHandler {

	public Sprite enableCardboardIcon;
	public Sprite disableCardboardIcon;
	private Image img;

	public void OnPointerClick(PointerEventData e) {
		img = GetComponent<Image>();
		if (GvrViewer.Instance.VRModeEnabled == true) {
			GvrViewer.Instance.VRModeEnabled = false;
			img.sprite = enableCardboardIcon;
		} else {
			GvrViewer.Instance.VRModeEnabled = true;
			img.sprite = disableCardboardIcon;
		}
	}

}
