using UnityEngine;
using System.Collections;

public class script1 : MonoBehaviour {


	public int scoreOfzo;
	public string name; 

	// Use this for initialization
	void Start () {
	
		string url = "http://17828.hosts.ma-cloud.nl/unityPingPong/unity.php";

		WWWForm form = new WWWForm ();

		form.AddField("Points", scoreOfzo);

		form.AddField("Name", name);

		WWW www = new WWW (url, form);

		StartCoroutine (WaitForRequest (www));
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;

		if (www.error == null) {
		
			Debug.Log ("www ok!: " + www.text);
		} else {
		
			Debug.Log("www error: " + www.error);
		}

	}

}