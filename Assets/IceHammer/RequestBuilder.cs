using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


namespace IceHammer {

    public class RequestBuilder {

        // only static methods
        private RequestBuilder() {}


        private static readonly string baseURL = "https://app.icehammer.org/api";


        public static UnityWebRequest GetProject(string projectID) {
            return UnityWebRequest.Get(baseURL + "/project/" + projectID);
        }

        public static UnityWebRequest GetSheet(string sheetID) {
            return UnityWebRequest.Get(baseURL + "/sheet/" + sheetID);
        }

        public static UnityWebRequest GetSchema(string schemaID) {
            return UnityWebRequest.Get(baseURL + "/schema/" + schemaID);
        }

        public static UnityWebRequest GetData(string schemaID) {
            return UnityWebRequest.Get(baseURL + "/schema/" + schemaID + "/data");
        }
    }

}

