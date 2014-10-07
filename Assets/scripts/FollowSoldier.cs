using UnityEngine;
using System.Collections;

public class FollowSoldier : MonoBehaviour {


	public GameObject soldier;
	public float speed;

	void Start () {
	}

	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, soldier.transform.position, speed*Time.deltaTime);
	}
}
