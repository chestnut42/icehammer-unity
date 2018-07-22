using System;


namespace IceHammer {

    [Serializable]
    public class Sheet {
        public string id;
        public string name;
        public string latestSchema;

        public override string ToString() {
        	return string.Concat(
        		"Sheet(",
        		name,
        		", schema: ",
        		(String.IsNullOrEmpty(latestSchema) ? "<null>" : latestSchema),
        		")"
        	);
        }
    }

}

