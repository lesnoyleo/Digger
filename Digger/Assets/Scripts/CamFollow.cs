using UnityEngine;

public class CamFollow : MonoBehaviour {
    public GameObject player;

	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
	}
}
