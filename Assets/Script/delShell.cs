using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delShell : MonoBehaviour {
    public void Update() {
        if (gameObject.transform.position.y < 0) {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject);
    }
}