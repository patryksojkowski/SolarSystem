using UnityEngine;
using System;

public class EarthMovement : MonoBehaviour {
    private double t = 0;
    public double radius = 100d;

    private void Start()
    {
        var t1 = Math.Acos(transform.position.x / radius);
        var t2 = Math.Acos(transform.position.z / radius);
        if(Math.Abs(t1 - t2) <= double.Epsilon)
        {
            t = t1;
            Debug.Log("Condition fullfiled. t =" + t.ToString());
        }
    }

    void FixedUpdate () {
        t += Math.PI / 18000;
        t %= 2 * Math.PI;
        transform.position = new Vector3((float)(radius*Math.Cos(t)), 0f, (float)(radius*Math.Sin(t)));
	}
}
