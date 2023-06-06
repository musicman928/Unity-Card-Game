using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
[CreateAssetMenu(fileName = "New Damage Effect", menuName = "Damage Effect")]
public class DamageEffect : Effect
{
    public GameObject target;
    [SerializeField] int damageAmount;


    public override void PerformEffect(){
        //target.GetComponent<PlayerController>().health -= damageAmount;
    }
}
