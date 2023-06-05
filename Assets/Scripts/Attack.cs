using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Basic Attack", menuName = "Basic Attack")]
public class Attack : ScriptableObject {

    public string attackName;
    public int damage;
    public CardColors[] cost;
    public Targets target;
    
    public delegate bool AttackCondition();
    public AttackCondition attackCondition;

    public Attack(string attackName, int damage, CardColors[] cost, Targets target) {
        this.attackName = attackName;
        this.damage = damage;
        this.cost = cost;
        this.target = target;

        attackCondition = () => {
            return true;
        };
    }

    /*

    
    public bool attackcondition()

    public void attackeffect()


    */

}
