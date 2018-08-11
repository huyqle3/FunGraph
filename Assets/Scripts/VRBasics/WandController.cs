using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandController : MonoBehaviour {

    #region Singleton

    public static WandController instance;

    #endregion

    private void Awake()
    {
        instance = this;
    }

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
        VRWandControls.instance.currentSpell = "Expelliarmus";

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

        projectile.GetComponent<Rigidbody>().velocity = projectileDir * 20.0f;

        SoundManager.instance.PlayAudioClip("ExpectoPatronum");

        Destroy(projectile, 8.0f);
    }

    public void InitializeExpectoPatronum()
    {
        VRWandControls.instance.currentSpell = "ExpectoPatronum";
    }
}
