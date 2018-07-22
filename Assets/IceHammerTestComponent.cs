using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class IceHammerTestComponent : MonoBehaviour {

	public static readonly string projectID = "kCeAKCduEOmlBgQgis23otP6VsT3Tvq9";


	void Start() {
        StartCoroutine(GetSheets());
    }
 
    IEnumerator GetSheets() {
        UnityWebRequest www = UnityWebRequest.Get("https://app.icehammer.org/api/project/" + projectID);
        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
        	IceHammer.Project project = JsonUtility.FromJson<IceHammer.Project>(www.downloadHandler.text);
            Debug.Log(project.id);
            Debug.Log(project.name);
            Debug.Log(project.sheets);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
