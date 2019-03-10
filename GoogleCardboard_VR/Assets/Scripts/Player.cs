using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header ("Bullet")]
    public GameObject bulletPrefab;
    public Transform spawmBullet;
    public float speed;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab);

        Physics.IgnoreCollision(bullet.GetComponent<Collider>(), spawmBullet.parent.GetComponent<Collider>());

        bullet.transform.position = spawmBullet.position;

        Vector3 rotation = bullet.transform.rotation.eulerAngles;

        bullet.transform.rotation = Quaternion.Euler(rotation.x, transform.eulerAngles.y, rotation.z);

        bullet.GetComponent<Rigidbody>().AddForce(spawmBullet.forward * speed, ForceMode.Impulse);

        StartCoroutine(DestroyByDelay(bullet,delay));

    }

    private IEnumerator DestroyByDelay(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(bullet);
    }
}
