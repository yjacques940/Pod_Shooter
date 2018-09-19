using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour {
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject BulletEmiter;
    [SerializeField] float fireRate = 1;
    // Use this for initialization
    private float timerLastShot = 0;
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        timerLastShot += Time.deltaTime;
        if (timerLastShot > fireRate ) {
            var fire1 = Input.GetAxis("Fire1");
            if (fire1 > 0) {
                Instantiate(Bullet, BulletEmiter.transform.position, BulletEmiter.transform.rotation);
                timerLastShot = 0;
            }
        }

    }
}
