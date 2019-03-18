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

    public virtual void Damage(int damage) {
        if (damage < 0) return;
        if (Health - damage < 0) {
            health = 0;
            Destroy(this.gameObject);
        } else {
            health -= damage;
        }
    }
}