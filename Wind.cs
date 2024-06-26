using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public float coefficient;   // 空気抵抗係数
    public Vector3 velocity;    // 風速

	void OnTriggerStay(Collider col) {
        if ( col.GetComponent<Rigidbody>() == null ) {
            return;
        }

        // 相対速度計算
        var relativeVelocity = velocity - col.GetComponent<Rigidbody>().velocity;

	    // 空気抵抗を与える
        col.GetComponent<Rigidbody>().AddForce(coefficient * relativeVelocity);
	}
}
