using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnergy : Energy {
    
    public CardColors EnergyValue;
    
    public BasicEnergy(CardColors EnergyValue) {
        this.EnergyValue = EnergyValue;
        //EnergyValue.Add(EnergyValue);
        name = "Basic " + Utility.Format(EnergyValue.ToString()) + " Energy";
        set = "NA";
        id = 0;
    }

    public override GameObject GetPrefab() {
        return Resources.Load<GameObject>("Prefabs/BasicEnergy");
    }
}