using UnityEngine;

public class GridCell : MonoBehaviour
{
    public int x, y;                            // 그리드에서의 위치(좌표)
    public DraggableRank currentRank;         //현재 칸에 있는 계급장
    public SpriteRenderer cellRenderers;


    private void Awake()
    {
        cellRenderers = GetComponent<SpriteRenderer>();
    }
    //좌표 초기화
    public void Initialize(int gridX, int gridY)
    {
        x = gridX;
        y = gridY;
        name = "Cell_" + x + "_" + y;
    }

    public bool isEmpty()
    {
        return currentRank == null;         //비어있으면 true 아니면 false 반환
    }

    public bool ContainsPosition(Vector3 position)
    {
        Bounds bounds = cellRenderers.bounds;
        return bounds.Contains(position);
    }

    public void SetRank(DraggableRank rank)
    {
        currentRank = rank;

        if (rank != null)
        {
            rank.currentCell = this;
        }

        rank.originalPosition = new Vector3(transform.position.x, transform.position.y, 0);
        rank.transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }
    
}
