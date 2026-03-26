using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float jumpForce = 5.0f;
    
    public Rigidbody rb;

    public bool isGrounded = true;      //땅 위에 있는지 체크하는변수 

    public int coinCount = 0;       //코인 획득 변수

    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //수평 이동 (키값을 받아옴, -1 ~ 1)
        float moveVertical = Input.GetAxis("Vertical");   //수직 이동   (동일)

        //강체의 속도의 값 변경 = 캐릭터 이동
        rb.linearVelocity = new Vector3(moveHorizontal * moveSpeed, rb.linearVelocity.y, moveVertical * moveSpeed);

        //점프 입력
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);     //위쪽 방향으로 설정한 힘수치만큼 순간적으로 힘을 가함
            isGrounded = false;                                         //점프를 하는 순간 땅에서 떨어졌기 때문에 False로
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("Coin"))
        {
            coinCount++;
            Destroy(other.gameObject);
        }
    }
}
