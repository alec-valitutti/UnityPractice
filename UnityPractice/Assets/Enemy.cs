using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Bullet;
    public Transform ShootTransform;
    private float counter;
    public float Speed;
    // Update is called once per frame
    private void OnDrawGizmos()
    {
        Debug.DrawRay(this.transform.position, -this.transform.forward);
        
    }
    void LateUpdate()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(this.transform.position,-this.transform.forward, out hit,Mathf.Infinity))
        {
            if (hit.transform.CompareTag("Player"))
            {
                //Debug.Log(hit.transform.name);

                if (counter<0f)
                {
                    Fire();
                }
            }
        }
        counter -= 1 * Time.deltaTime;
    }
    public void Fire()
    {
        if (counter<0)
        {
            Debug.Log("fire");
            Instantiate(Bullet,ShootTransform.position,ShootTransform.rotation);
            counter = Speed;
        }
    }
}
