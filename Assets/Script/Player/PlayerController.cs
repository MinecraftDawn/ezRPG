using UnityEngine;

public class PlayerController : Entity {
    private float speed = 0.05f;

    public void Update() {
        moving();
        rotating();
        shoot();
    }

    private void moving() {
        //向前
        if (Input.GetKey(KeyCode.W)) {
            transform.Translate(Vector3.forward * speed);
        }
        //向後
        if (Input.GetKey(KeyCode.S)) {
            transform.Translate(Vector3.back * speed);
        }
        //向左
        if (Input.GetKey(KeyCode.A)) {
            transform.Translate(Vector3.left * speed);
        }
        //向右
        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector3.right * speed);
        }
    }

    private void rotating() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate(0f, 1 * 2f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate(0f, -1 * 2f, 0f);
        }
    }

    private void OnCollisionEnter(Collision other) {
        Entity enemy = other.gameObject.GetComponent<Entity>();

        if (enemy != null && other.gameObject.CompareTag("enemy")) {
            Debug.Log(enemy.AttackPower);
            Damage(enemy.AttackPower);
        }
    }

    private void shoot() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Shell shell = new Shell(gameObject.transform.GetChild(0).position,
                transform.rotation);
            shell.createShell();
        }
    }


    public override void Attack(Entity otherEntity) {
        otherEntity.Damage(AttackPower);
    }

    public override void Damage(int damage) {
        if (damage < 0) return;
        health -= damage;
        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }
}