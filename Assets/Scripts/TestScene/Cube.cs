using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    MeshRenderer cubeRenderer;



    private void Start()
    {
        cubeRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            MeshRenderer ballRenderer = collision.gameObject.GetComponent<MeshRenderer>();
            Material ballMaterial = ballRenderer.material;
            cubeRenderer.material = ballMaterial;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            MeshRenderer ballRenderer = other.gameObject.GetComponent<MeshRenderer>();
            Material ballMaterial = ballRenderer.material;
            cubeRenderer.material.color = ballMaterial.color;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            cubeRenderer.material.color = Color.yellow;
        }
    }
}
