using UnityEngine;

public class Shell : MonoBehaviour {
    private int power;
    private float speed = 1;

    public int Power {
        get { return power; }
        set {
            if (value < 0) {
                power = 0;
            } else {
                power = value;
            }
        }
    }

    public float Speed {
        get { return speed; }
    }

    public void Update() {
        if (gameObject.transform.position.y < 0) {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject);

        Entity entity = other.gameObject.GetComponent<Entity>();
        if (entity != null) {
            entity.Damage(Power);
        }
    }
}