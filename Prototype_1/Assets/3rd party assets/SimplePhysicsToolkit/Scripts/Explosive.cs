﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/* Simple Physics Toolkit - Explosive
 * Description: Explosive applies abrubt force to any rigidbodies within range
 * Required Components: Collider
 * Author: Dylan Anthony Auty
 * Version: 1.1
 * Last Change: 2020-12-03
*/

namespace SimplePhysicsToolkit {
    [RequireComponent(typeof(Collider))]
    public class Explosive : MonoBehaviour {
        public float power = 50f;
        public float radius = 10f;

        public bool onlyAffectInteractableItems = false;

        public GameObject explosionPrefab;

        public UnityEvent onExplode;
        public ColliderEvent onApplyForce;

        void OnDrawGizmos(){
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere (transform.position, radius);
        }

        void OnTriggerEnter(Collider other){
            if (other.GetComponent<Rigidbody>()) {
                explode();
            }
        }

        void OnCollisionEnter(Collision collision){
            if (collision.gameObject.GetComponent<Rigidbody>()) {
                explode();
            }
        }

        void explode(){
            onExplode.Invoke();

            Vector3 pos = transform.position;

            Collider[] objects = Physics.OverlapSphere (transform.position, radius);
            foreach (Collider col in objects) {
                if (col.GetComponent<Rigidbody> ()) { //Must be rigidbody
                    if (onlyAffectInteractableItems) {
                        if (col.GetComponent<InteractableItem> ()) {
                            applyExplosiveForce(col);
                        }
                    } else {
                        applyExplosiveForce(col);
                    }

                }
            }
            if(explosionPrefab != null){
                Instantiate (explosionPrefab, transform.position, transform.rotation);
            }

            Destroy (transform.gameObject);
        }

        void applyExplosiveForce(Collider col){
            onApplyForce.Invoke(col);
            col.GetComponent<Rigidbody>().AddExplosionForce(power, transform.position, radius, 1.0f, ForceMode.Impulse);
        }
    }
}
