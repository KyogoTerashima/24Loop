using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacterController : MonoBehaviour
{
    //アニメーションのコンポーネント
    private Animator myAnimator;
    //移動のためのコンポーネントを入れる
    private Rigidbody myRigdbody;
    //前へと進む力
    private float forwordForce = 100f;
    //前へと進む力を減衰させる
    private float coefficient = 0.75f;



    // Start is called before the first frame update
    void Start()
    {
        this.myAnimator = GetComponent<Animator>();
        this.myAnimator.SetFloat("Speed_f", 0.1f);
        //リジットの取得
        this.myRigdbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Wキーが押されたら前へと進む
        if (Input.GetKey(KeyCode.W) && this.myAnimator.GetFloat("Speed_f") <= 3)
        {
            float Speed = this.myAnimator.GetFloat("Speed_f");
            float mySpeed = Speed * this.forwordForce;
            this.myAnimator.SetFloat("Speed_f",  mySpeed);
            this.myRigdbody.AddForce(Speed, 0, 0);
            
            
        }

        //キーが離されたら前の動きを止める
        if (Input.GetKeyUp(KeyCode.W))
        {
            this.myAnimator.SetFloat("Speed_f", 0.1f);
            Debug.Log(this.myAnimator.GetFloat("Speed_f"));
            this.myRigdbody.velocity = Vector3.zero;
            Debug.Log(this.myRigdbody.velocity = Vector3.zero);
        }
    }
}
