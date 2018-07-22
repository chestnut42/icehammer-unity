using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


namespace IceHammer {

    public class ResponseParser {

        // only static methods
        private ResponseParser() {}


        public static Project ParseProject(UnityWebRequest request) {
            return JsonUtility.FromJson<Project>(request.downloadHandler.text);
        }

        public static Sheet ParseSheet(UnityWebRequest request) {
            return JsonUtility.FromJson<Sheet>(request.downloadHandler.text);
        }
    }

}

