using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnergy : Energy {
    
    public BasicEnergy(CardColors type) {
        value.Add(type);
        name = "Basic " + Utility.FormatAllLower(type.ToString()) + " Energy";
        set = "NA";
        id = 0;
    }

    public override GameObject GetPrefab() {
        return Resources.Load<GameObject>("Prefabs/BasicEnergy.prefab");
    }

}