using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DementorController : MonoBehaviour {

    Animator dementorAnimator;

    private bool collided = false;
    private bool done = false;

	void Start () {
        dementorAnimator = this.GetComponent<Animator>();
	}

    private void Update()
    {
        if (collided && !done)
        {
            // Update the score.
            Spawner.instance.UpdateScore();

            Spawner.instance.count -= 1;

            dementorAnimator.Play("Damaged", -1, 0f);

            collided = false;
            done = true;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("COLLIDED");

        if (collision.gameObject.name == "ExpelliarmusProjectile(Clone)")
        {
            GameObject impact = Instantiate(Resources.Load("Prefabs/ExpelliarmusImpact"), collision.transform.position, collision.transform.rotation) as GameObject;
            Destroy(impact, 1);

            Destroy(collision.gameObject);

            collided = true;

            Destroy(this.gameObject, 1.1f);
        }
    }
}
