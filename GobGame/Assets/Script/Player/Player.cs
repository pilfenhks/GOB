using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Camera cam;
    public LayerMask MuroU;
    public LayerMask MuroD;
    public LayerMask MuroR;
    public LayerMask MuroL;
    public Vector3 posCollMuros;
    public float radioMuros;
    public bool tocaMuroU;
    public bool tocaMuroD;
    public bool tocaMuroR;
    public bool tocaMuroL;

	void Start () {
        cam = Camera.main;
        cam.transform.parent = this.transform;
	}
	
	void Update () {
        Collider2D colisionMuroU = Physics2D.OverlapCircle(transform.position + posCollMuros, radioMuros, MuroU);
        Collider2D colisionMuroD = Physics2D.OverlapCircle(transform.position + posCollMuros, radioMuros, MuroD);
        Collider2D colisionMuroR = Physics2D.OverlapCircle(transform.position + posCollMuros, radioMuros, MuroR);
        Collider2D colisionMuroL = Physics2D.OverlapCircle(transform.position + posCollMuros, radioMuros, MuroL);
        if (colisionMuroU)
            tocaMuroU = true;
        else
            tocaMuroU = false;

        if (colisionMuroD)
            tocaMuroD = true;
        else
            tocaMuroD = false;

        if (colisionMuroR)
            tocaMuroR = true;
        else
            tocaMuroR = false;

        if (colisionMuroL)
            tocaMuroL = true;
        else
            tocaMuroL = false;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position + posCollMuros, radioMuros);
    }
}
