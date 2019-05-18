using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterStream : MonoBehaviour {

    [SerializeField] string affectedTag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == affectedTag)
        {
            other.GetComponent<ElementAffected>().Affect(ElementManager.Elements.Water);
        }
    }
}
