using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EffectType{DamageEffect}
[System.Serializable]
[CreateAssetMenu(fileName = "New Card Effect", menuName = "Effect")]

public class CardEffect : ScriptableObject {

    // public delegate void Effect();
    // Effect[] EffectQueue;


    public List<EffectType> effecctsssss;
    public List<Effect> Effects; 

    public int SomeInt;
    public void Invoke() {
        
    }

    
}
