using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barbarian : MonoBehaviour
{
    [SerializeField]float speed;
    void Start()
    {
        
    }
    void Update()
    {
        Andar();
    }

    public void Andar()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        transform.position = transform.position + movement * speed * Time.deltaTime;

    }
    
}
