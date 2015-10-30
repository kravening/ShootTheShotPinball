using UnityEngine;
using System.Collections;

public class LoadScene : MonoBehaviour {
	[SerializeField]
	private string level;

	public void ChangeLevel(){
		Application.LoadLevel(level);
	}
}
