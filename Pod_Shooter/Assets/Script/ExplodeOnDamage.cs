using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnDamage : MonoBehaviour, Damagable {
    
    [SerializeField]float ExplosionRadius = 5;
    [SerializeField] float ExplositionDamage = 1;
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
        //instatiate particle system
        Destroy(gameObject);
    }
}
