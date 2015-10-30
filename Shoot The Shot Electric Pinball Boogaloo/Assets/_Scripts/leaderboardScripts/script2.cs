using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class script2 : MonoBehaviour {

    public Text[] fileTexts;
    
    // Use this for initialization
    void Start () {
		
		string url = "http://17828.hosts.ma-cloud.nl/unityPingPong/unity2.php";
		
		WWW www = new WWW (url);
		
		StartCoroutine (WaitForRequest (www));


		}

	
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		
		if (www.error == null)
        {
  
  
            ReadIncomingData(www.text);

			Debug.Log ("www ok!: " + www.text);

		} else {
			
			Debug.Log("www error: " + www.error);
            fileTexts[0].text = www.error;
		}
		
	}


    public void ReadIncomingData(string incomingString)
    {
        string[] splitData = incomingString.Trim().Split('\n');

        if (incomingString == string.Empty)return;
        
        int timer = 0;
        foreach (string entry in splitData)
        {
            if (entry.Contains("\t"))
            {
                string[] temp = entry.Split('\t');

                string _name = temp[1];
                string _score = temp[0];

                if (timer < 10)
                {
                    fileTexts[0].text += _name + '\n';
                    fileTexts[1].text += _score + '\n';
                    timer++;
                }
            }

        }
    }
}