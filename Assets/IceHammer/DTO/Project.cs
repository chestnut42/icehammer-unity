using System;


namespace IceHammer {

    [Serializable]
    public class Project {
        public string id;
        public string name;
        public string[] sheets;

        public override string ToString() {
        	return string.Concat(
        		"Project(",
        		name,
        		", sheets: [",
        		string.Join(",", sheets),
        		"])"
        	);
        }
    }

}

