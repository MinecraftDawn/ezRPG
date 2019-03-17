public class EnemyBoss : Entity {
    private void Awake() {
        AttackPower = 30;
    }

    public override void Attack(Entity otherEntity) {
        otherEntity.Damage(AttackPower);
    }

    public override void Damage(int damage) {
        if (Health - damage < 0) {
            health = 0;
        } else {
            health -= damage;
        }
    }
}