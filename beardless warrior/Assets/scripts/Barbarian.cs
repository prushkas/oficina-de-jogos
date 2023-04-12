using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : MonoBehaviour
{
    [SerializeField]float speed;
    private bool attacking;
    void Start()
    {
        
    }
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position = transform.position + movement * speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Z))
        {
            attacking = true;
            
            if()
        }
    }
}
