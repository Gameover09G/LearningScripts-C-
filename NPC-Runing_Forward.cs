using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{       int level = 2;
        int health = 5;
        float speed = 1.5f;
        

    // Start is called before the first frame update
    void Start()
    {
        health = 5 + level;
    }

    // Update is called once per frame
    void Update()
    {   
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }