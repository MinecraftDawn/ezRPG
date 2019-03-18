using UnityEngine;

public class EnemyBoss : Entity {
    private void Update() {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null) {
            gameObject.transform.LookAt(player.transform);
            gameObject.transform.Translate(transform.forward * Time.deltaTime);
        }
    }

    private void Awake() {
        AttackPower = 30;
    }

    public override void Attack(Entity otherEntity) {
        otherEntity.Damage(AttackPower);
    }

}