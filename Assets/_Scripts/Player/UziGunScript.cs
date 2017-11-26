using UnityEngine;

public class UziGunScript : MonoBehaviour {

    public float damage = 10f;
    public float ranage = 100f;

    public GameObject shootpoint;
    public ParticleSystem muzzleFlash;

    public VRTK.VRTK_ControllerEvents controllerEvents;

    // Update is called once per frame
    void Update () {

        if (Input.GetButtonDown("Fire1") || controllerEvents.triggerPressed)
        {
            Shoot();
        }
		
	}

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(shootpoint.transform.position, shootpoint.transform.forward, out hit, ranage))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
}
