using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public float counter;

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector3(10,10,10)*Time.deltaTime);
        transform.Translate(transform.forward * speed *Time.deltaTime);
        counter -= 5 * Time.deltaTime;
        if (counter <=0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
        if (other.tag == "Breakable")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
