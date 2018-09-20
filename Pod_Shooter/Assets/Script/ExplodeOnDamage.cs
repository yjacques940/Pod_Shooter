using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnDamage : MonoBehaviour, Damagable {
    
    [SerializeField]float ExplosionRadius = 5;
    [SerializeField] float ExplositionDamage = 1;
    [SerializeField] GameObject explositionParticle;
    [SerializeField] GameObject fireParticle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void DealDamage(int Damage) {
        Explode();
    }

    private void Explode() {
        Instantiate(fireParticle, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(explositionParticle,gameObject.transform.position,gameObject.transform.rotation);
        Destroy(gameObject);
    }
}
