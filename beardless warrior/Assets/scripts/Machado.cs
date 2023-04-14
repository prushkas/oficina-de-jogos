using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Machado : MonoBehaviour
{
    [SerializeField] private Transform hand;
    private Camera main;
    private Vector3 mousePosition;
    void Start()
    {
        main = Camera.main;
    }
    
    void Update()
    {
        
        mousePosition = main.ScreenToWorldPoint(Input.mousePosition);
        float angle = Mathf.Atan2(mousePosition.y - transform.position.y, mousePosition.x - transform.position.x) * Mathf.Rad2Deg;
        hand.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}
