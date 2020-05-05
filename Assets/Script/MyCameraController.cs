using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{

    private GameObject playerCharacter;

    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        this.playerCharacter = GameObject.Find("PlayerCharacter");
        this.difference = this.playerCharacter.transform.position.x - this.transform.position.x;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.playerCharacter.transform.position.x - this.difference,  this.transform.position.y, this.transform.position.z);
        
    }
}
