using UnityEngine;

public class CubeManager : MonoBehaviour
    
{
    public CubeGenerator[] generatedCubes = new CubeGenerator[5];

    public float timer = 0.0f;
    public float interval = 3.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            RandomizeCubeAcitivation();
            timer = 0.0f;
        }
    }

    public void RandomizeCubeAcitivation()
    {
        for (int i = 0; i < generatedCubes.Length; i++)                 //각 큐브 생성 함수를 랜덤하게 호출
        {
            int randomNum = Random.Range(0, 2);                         //랜덤값 0,1 (50% 확률로 생성)
            if (randomNum == 1)
            {
                generatedCubes[i].GenCube();
            }
        }
    }
}
