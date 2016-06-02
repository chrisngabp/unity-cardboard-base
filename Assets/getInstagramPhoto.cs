using UnityEngine;
using System.Collections;
using SimpleJSON;

public class getInstagramPhoto : MonoBehaviour {

	IEnumerator Start() {
		
		/*WWW w = new WWW("https://api.instagram.com/v1/users/1058408835/media/recent/?access_token=1283749287.6f36d95.cad105b24f584a319f805973d5073a23");
		yield return w;

		string jsonStr = w.text;
		string imgUrl = JSON.Parse (jsonStr)["data"][0]["images"]["standard_resolution"]["url"].Value; //[0]["images"]["standard_resolution"]["url"].Value
*/
		string imgUrl = "http://www.roadtovr.com/wp-content/uploads/2014/09/Venice.Still001.jpeg";
		// Start a download of the given URL
		WWW www = new WWW(imgUrl);

		// Wait for download to complete
		yield return www;
		Renderer rend = GetComponent<Renderer>();
		//Shader photoShader = new Shader ();
		rend.material.mainTexture = www.texture;
	}
}
