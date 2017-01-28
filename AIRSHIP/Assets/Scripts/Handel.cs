using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handel : MonoBehaviour {

    public Animator anim;
    public Animator anim2;

    public GameObject deur;

    public float  timer = 0;

    public static float timerdeur = 0;

	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
        anim2 = deur.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        timer -= 1 * Time.deltaTime;

        timerdeur -= 1 * Time.deltaTime;

        if(timer < 0)
        {

            timer = 0;

        }

        if(timer == 0)
        {

            anim.SetTrigger("NotUsed");
            anim.ResetTrigger("Used");

        }

        if(timerdeur < 0)
        {

            timerdeur = 0;

        }

        if(timerdeur == 0)
        {

            anim2.SetTrigger("Closed");
            anim2.ResetTrigger("Open");

        }
		
	}

    public void OnTriggerStay(Collider other) {

        if (Input.GetButtonDown("Fire1") && timer == 0)
        {

            timer += 1f;
            anim.SetTrigger("Used");
            anim.ResetTrigger("NotUsed");

            if(timerdeur == 0)
            {

                timerdeur = 5;
                anim2.SetTrigger("Open");
                anim2.ResetTrigger("Closed");

            }
        }
    }
}
