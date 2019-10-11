using UnityEngine;

public class RangedWeaponController : MonoBehaviour {

    public ProjectileController projectilePrefab;
    public Camera playerCam;
    public Transform arrowSpwan;
    public float shootForce;

    void Update() {
        // Fire the projectile when the left of the mouse is clicked
        if (Input.GetButtonDown("Fire1")) {
            
            Shoot();

        }
    }

    void Shoot() {
        ProjectileController projectile = Instantiate<ProjectileController>(projectilePrefab, arrowSpwan.position, projectilePrefab.transform.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = playerCam.transform.forward * shootForce;
    }

}