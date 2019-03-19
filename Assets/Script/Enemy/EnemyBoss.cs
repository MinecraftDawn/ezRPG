using UnityEngine;

public class EnemyBoss : EnemyBase {
    private const float reloadTime = 1f;
    private float now = 0;

    private void Update() {
        move();

        if (now < Time.time) {
            now = Time.time + reloadTime;
            shoot();
        }

    }

    private void Awake() {
        AttackPower = 30;
        speed = 1.1f;
    }

    public override void Attack(Entity otherEntity) {
        otherEntity.Damage(AttackPower);

    }

}