using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.Mathematics;
using UnityEngine;

public class Machado : MonoBehaviour
{
    [SerializeField] private Transform hand;
    [SerializeField] private Transform firepoint;
    private Camera main;
    private Vector3 mousePosition;
    private bool attacking;
    private float angle;
    [SerializeField] GameObject machado;
    void Start()
    {
        main = Camera.main;
    }
    
    void Update()
    {
        
        mousePosition = main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mousePosition.y - transform.position.y, mousePosition.x - transform.position.x) * Mathf.Rad2Deg;
        Debug.Log(angle);
        hand.rotation = Quaternion.Euler(0f, 0f, angle);

        Attacking();
    }
    
    public void Attacking() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            attacking = true;
            GameObject m = Instantiate(machado, firepoint.position, firepoint.rotation);


            
            Destroy(m, 5f);
        }
    }
}
