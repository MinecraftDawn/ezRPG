using UnityEngine;

public class Enemy : Entity {

    public override void Attack(Entity otherEntity) {
        otherEntity.Damage(AttackPower);
    }

}