using UnityEngine;

public class MyBall : MonoBehaviour
{
    void Start()
    {
                
    }


    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) //어제 배운 온 버튼과 똑같음
    {
        Debug.Log(collision.gameObject.name + " 와/과 충돌함");
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("아야;");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("한기가 느껴진다");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("몸이 따뜻해진다");
    }
}
