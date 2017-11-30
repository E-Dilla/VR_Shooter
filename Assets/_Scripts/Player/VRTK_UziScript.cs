namespace VRTK.Examples
{
    using UnityEngine;

    public class VRTK_UziScript : VRTK_InteractableObject
    {

        public float damage = 10f;
        public float ranage = 100f;
        public float firerate = 15f;


        public ParticleSystem muzzleFlash;
        public GameObject shootpoint;
        public GameObject impactEffect;

        private float nextTimeToFire = 0;

        public override void StartUsing(VRTK_InteractUse usingObject) 
        {
            base.StartUsing(usingObject);
            if(Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / firerate;
                Shoot();
            }

            
        }

        // Use this for initialization
        void Start()
        {
            
        }

        void Shoot()
        {
            muzzleFlash.Play();
            RaycastHit hit;
            if (Physics.Raycast(shootpoint.transform.position, shootpoint.transform.forward, out hit, ranage))
            {
                Debug.Log(hit.transform.name);

                Target target = hit.transform.GetComponent<Target>();
                Enemy_One enemyone = hit.transform.GetComponent<Enemy_One>();

                if (target != null)
                {
                    target.TakeDamage(damage);
                }

                if (enemyone != null)
                {
                    enemyone.TakeDamage(damage);
                }

                GameObject impactHit =  Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactHit, 1f);

            }
        }
    }
}