using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Target : MonoBehaviour
    {
        public Rigidbody rb;
        

        //health of zombie 
        public float health = 50f;

        //time it takes for zombie to despawn after death.
        public float despawnDelay = 1f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        //regulates health and damage taken
        public void TakeDamage(float amount)
        {
            health -= amount;
            if (health <= 0f)
            {
                Die();
            }
        }

        void Die()
        {
            //Destroy(gameObject);
            GameObject armature = gameObject.transform.GetChild(0).gameObject;

            Animator target_animator = armature.GetComponent<Animator>();

            target_animator.SetBool("isDead", true);

            
            //ZombieCharactercript script = gameObject.GetComponent<ZombieCharacterScript>();

            //rb = GetComponent<Rigidbody>();
            //destroys gameobject
            Destroy(gameObject, despawnDelay);
            //rb.velocity = Vector3.zero;
        }

    }



