using UnityEngine;
using UnityEngine.InputSystem;

public class MyCharacter : MonoBehaviour
{
    private Vector3 moveInput;
    public int Health = 100; //public = inspecter 창에서 조작가능하게 만드는 코드
    public float Timer = 1.0f; // 타이머 설정
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = Health + 100;
        
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
        
        Timer = Timer - Time.deltaTime; //시간 변수를 매 프레임마다 감소 
        if (Timer <= 0)
        {
            Timer = 10f;
            Health = Health - 20;
        }
        
        if (Health <= 0)
        {
            Destroy(this.gameObject); 
        }
    }
}
