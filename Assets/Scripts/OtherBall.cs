using System;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    private MeshRenderer mesh;
    private Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "My Ball")
            mat. color = new Color (0, 0, 0);
    }
    
    private void OnCollisionExit(Collision collision)
        
    {
        if (collision.gameObject.name == "My Ball")
            mat.color = new Color (1, 1, 1);
    }
    
    

  
}