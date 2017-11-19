using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private new Rigidbody2D rigidbody2D;
    public float walkSpeed = 4;

    private PlayerAnimtaion playerAnimtaion;

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimtaion = GetComponent<PlayerAnimtaion>();
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyUp(KeyCode.K) && rigidbody2D.velocity.y == 0){
            rigidbody2D.AddForce(Vector2.up * 300f);
            playerAnimtaion.PlayerJunpAnimation();
            return;
        }

        #region controller move

        float h = Input.GetAxis("Horizontal");
        if(h > 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 180, 0));
        }
        else if(h < 0)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        }

        var v2 = rigidbody2D.velocity;

        if(h != 0)
        {
            rigidbody2D.velocity = new Vector2(h * walkSpeed, v2.y);
            playerAnimtaion.PlayerWalkAnimation();
            return;
        }

        #endregion

        rigidbody2D.velocity = new Vector2(0, v2.y);
        playerAnimtaion.PlayerIdleAnimation();
        


	}
}
