using UnityEngine;

public abstract class Entity : MonoBehaviour {
    protected int health = 100;
    private int attackPower = 10;

    public int Health {
        get { return health; }
    }

    public int AttackPower {
        get { return attackPower; }
        protected set { attackPower = value; }
    }

    public abstract void Attack(Entity otherEntity);

    public abstract void Damage(int damage);
}