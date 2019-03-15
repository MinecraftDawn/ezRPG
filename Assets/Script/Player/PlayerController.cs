using UnityEngine;

public class PlayerController : MonoBehaviour {
    private float speed = 0.05f;
    public int health = 100;

    public void Update() {
        moving();
        rotating();
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
        Enemy enemy = other.gameObject.GetComponent<Enemy>();

        if (enemy != null && other.gameObject.CompareTag("enemy")) {
            Debug.Log(enemy.AttackPower);
            Damage(enemy.AttackPower);
        }
    }

    private void Damage(int value) {
        if (value < 0) return;

        health -= value;
        if (health <= 0) {
            Destroy(this.gameObject);
        }
    }
}