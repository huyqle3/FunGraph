using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWall : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ExpelliarmusProjectile(Clone)")
        {
            GameObject impact = Instantiate(Resources.Load("Prefabs/ExpelliarmusImpact"), collision.transform.position, collision.transform.rotation) as GameObject;
            Destroy(impact);

            Destroy(collision.gameObject);

            Destroy(this);
        }
    }
}
