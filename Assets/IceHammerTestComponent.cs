using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using IceHammer;


public class IceHammerTestComponent : MonoBehaviour {

	public static readonly string projectID = "G_271bd-mg1ZPrna0XxAS0aT56BxS0tA";


    public string[] sheets;


	void Start() {
        StartCoroutine(GetProject());
    }
 
    IEnumerator GetProject() {
        UnityWebRequest www = RequestBuilder.GetProject(projectID);
        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
        	Project project = ResponseParser.ParseProject(www);
            sheets = project.sheets;

            Debug.Log(project.id);
            Debug.Log(project.name);
            Debug.Log(project.sheets);

            yield return GetSheets(project);
        }
    }

    IEnumerator GetSheets(Project project) {
        UnityWebRequest www = RequestBuilder.GetSheet(project.sheets[0]);
        yield return www.SendWebRequest();

        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
        else {
            Sheet sheet = ResponseParser.ParseSheet(www);
            Debug.Log("sheet: " + sheet.name + ", " + sheet.id + ", " + sheet.latestSchema);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
