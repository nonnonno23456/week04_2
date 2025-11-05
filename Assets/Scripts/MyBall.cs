using UnityEngine;

public class MyBall : MonoBehaviour
{
    private Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.name == "Cube")
            rigid.AddForce(Vector3.up * 4, ForceMode.Impulse) ;
    }
    
    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode. Impulse);
    }

}
