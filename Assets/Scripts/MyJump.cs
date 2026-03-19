using UnityEngine;
using UnityEngine.UI;
public class MyJump : MonoBehaviour
{
    public Rigidbody rigibody;
    public float power = 200f;
    public Text timeUI;     //시간 UI 생성
    public float Timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Timer = Timer + Time.deltaTime; //타이머 상승
        timeUI.text = Timer.ToString(); // 타이머 숫자를 문자열 변수로 변경한 후 표시

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigibody.AddForce(transform.up * power);
        }
        
    }
}
