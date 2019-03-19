public class Enemy : EnemyBase {

    private void Update() {
        move();
    }

    public override void Attack(Entity otherEntity) {
        otherEntity.Damage(AttackPower);
    }
}