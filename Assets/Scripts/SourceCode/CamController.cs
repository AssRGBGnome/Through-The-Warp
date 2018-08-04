using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public GameObject Player;
    public GameObject Cam;
    Vector3 V;
    Vector3 P;

    private void LateUpdate()
    {
        Vector3 pos = transform.position;
        pos.x = Cam.transform.position.x;
        transform.position = pos;

        V = this.gameObject.transform.position;
        P = Player.gameObject.transform.position;
        V.y = 0;

        if (P.x >= 14.216f)
        {
            V.x = 28.44f;
            V.y = 0f;
            Camera.main.transform.position = V;
        }
        else { V.x = 0; Camera.main.transform.position = V; }

    }
}