using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public CharacterController c;
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        /*I don't think this is the most optimized, assigning this in the 
         * inspector is the way to do it but idc...
        */
        //c = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        PlayerShoot();
    }
    public void PlayerMove()
    {
        #region You could use this code to move an object around with the keyboard but I wouldn't reccomend it
        var move = new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        c.Move(move * Time.deltaTime * Speed);
        //if (Input.GetKey(KeyCode.W))
        //{
        //    this.gameObject.transform.Translate(new Vector3(0,0,Speed*Time.deltaTime));
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    this.gameObject.transform.Translate(new Vector3(0, 0, -Speed * Time.deltaTime));
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    this.gameObject.transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    this.gameObject.transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
        //}
        #endregion
        // Using CharacterController component

    }
    public void PlayerShoot()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //instatiate the bullet object

            Instantiate(Bullet,
                new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z + 1)
                ,this.transform.rotation);
        }
    }

}
