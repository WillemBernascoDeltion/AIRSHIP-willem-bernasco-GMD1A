using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{

    public enum Floor
    {
        Een,

        Twee
    }

    public Floor floor;

    public Vector3 targetFloor = new Vector3(109.43f, 449.826f, -436.25f);

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            floor = Floor.Een;

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            floor = Floor.Twee;

        }


        Aanpassen();

        Control();

    }

    void Aanpassen()
    {

        if (floor == Floor.Een)
        {

            targetFloor.y = 449.826f;

        }

        if (floor == Floor.Twee)
        {

            targetFloor.y = 444.514f;

        }
    }

    void Control()
    {

        transform.position = Vector3.MoveTowards(transform.position, targetFloor, 0.1f);

    }
}