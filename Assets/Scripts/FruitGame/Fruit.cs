using UnityEngine;

public class Fruit : MonoBehaviour
{
    public int fruitType;           //과일 index 설정(0: 사과, 1: 레몬 등등)
    public bool hasMerged = false;  //과일이 합쳐졌는지 확인하는 플래그


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasMerged)
           return;                 //이미 합쳐진건 무시
        Fruit otherFruit = collision.gameObject.GetComponent<Fruit>();

        if (otherFruit != null && !otherFruit.hasMerged && otherFruit.fruitType == fruitType)
        {
            hasMerged = true;           //합쳐짐 표시
            otherFruit.hasMerged = true;//합쳐짐 표시

            Vector3 mergePosition = (transform.position + otherFruit.transform.position) / 2f;  //두 과일의 중간 위치 계산

            //게임 매니저에서 Merge 구현 된 것을 호출
            FruitGame gameManager = FindAnyObjectByType<FruitGame>();

            if (gameManager != null)
            {
                gameManager.MergeFruits(fruitType, mergePosition);
            }

            //과일들 제거
            Destroy(otherFruit.gameObject);
            Destroy(gameObject);
        }
    }

}
