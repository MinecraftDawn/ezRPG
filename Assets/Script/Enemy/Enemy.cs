using UnityEngine;

public class Enemy : MonoBehaviour, IEnemy {
    protected int attackPower = 10;

    public virtual int AttackPower {
        get { return attackPower;}
        set { }
    }

}