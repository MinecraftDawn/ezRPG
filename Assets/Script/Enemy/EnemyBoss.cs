public class EnemyBoss : Enemy {

    public override int AttackPower {
        get { return 2 * attackPower;}
        set {}
    }
}