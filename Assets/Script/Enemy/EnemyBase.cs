using UnityEngine;

public abstract class EnemyBase : Entity {
    public GameObject shell;
    protected float speed = 1;
    protected virtual void move() {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null) {
            gameObject.transform.LookAt(player.transform);
            gameObject.transform.Translate(transform.forward * Time.deltaTime * speed);
        }
    }

    protected virtual void shoot() {
        GameObject shellObject = MonoBehaviour.Instantiate(shell, gameObject.transform.GetChild(0).position,
            transform.rotation);

        Rigidbody shellRigidbody = shellObject.GetComponent<Rigidbody>();

        shellRigidbody.AddForce(shellObject.transform.forward * 50f + shellObject.transform.up * 8f);

        Shell shellScript = shellObject.GetComponent<Shell>();
        shellScript.Power = AttackPower;
    }
}