using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour {

    GameObject spell;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	
	}

    // Expelliarmus
    public void InitializeExpelliarmus()
    {
        if (!spell)
        {
            GameObject expelliarmusOrb = Instantiate(Resources.Load("Prefabs/Expelliarmus"), this.transform) as GameObject;
            spell = expelliarmusOrb;

            GameObject expelliarmusProjectile = expelliarmusOrb.transform.Find("ExpelliarmusProjectile").gameObject;

            ExpelliarmusProjectile(expelliarmusProjectile);
        }
        else
        {
            CreateExpelliarmusProjectile();
        }
    }

    public void CreateExpelliarmusProjectile()
    {
        GameObject expelliarmusProjectile = Instantiate(Resources.Load("Prefabs/ExpelliarmusProjectile"), spell.transform) as GameObject;
        ExpelliarmusProjectile(expelliarmusProjectile);
    }

    public void ExpelliarmusProjectile(GameObject projectile)
    {
        Vector3 projectileDir = -projectile.transform.right;
        Vector3 projectilePos = projectile.transform.position + projectileDir * 1.5f;

        projectile.GetComponent<Rigidbody>().velocity = projectileDir * 10.0f;

        Destroy(projectile, 8.0f);
    }
}
