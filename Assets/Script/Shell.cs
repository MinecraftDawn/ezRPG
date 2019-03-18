using UnityEngine;

public class Shell {
    private int power;
    private float speed;

    private GameObject original = Resources.Load<GameObject>(
        "Prefab" + "\\" + "shell");

    private Vector3 position;
    private Quaternion rotation;

    public Shell(Vector3 position, Quaternion rotation) {
        this.position = position;
        this.rotation = new Quaternion(rotation.x, rotation.y, rotation.z, rotation.w);
    }

    public void createShell() {
        GameObject shell = MonoBehaviour.Instantiate(original, position, rotation);
        Rigidbody shellRigidbody = shell.GetComponent<Rigidbody>();
        shellRigidbody.AddForce(shell.transform.right * 1000f + shell.transform.up * 20f);

    }

}