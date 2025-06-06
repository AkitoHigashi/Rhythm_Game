using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    [SerializeField] float Speeds_Notes = 1f;
    
        // Update is called once per frame
    void Update()
    {
        transform.position -= Vector2.right * Time.deltaTime * Speeds_Notes;
    }
}
