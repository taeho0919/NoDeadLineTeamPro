using UnityEngine;

public class MapChecker : MonoBehaviour
{
    [SerializeField] private GameObject[] targets;
    [SerializeField] private Collider2D rangeCollider; // 범위를 정의하는 콜라이더 (예: 플레이어 감지 범위)

    private Vector3[] targetPositions; // 비활성화되어도 위치를 알 수 있도록 캐싱
    private bool[] isActiveState;

    private void Awake()
    {
        if (rangeCollider == null)
            rangeCollider = GetComponent<Collider2D>();

        targetPositions = new Vector3[targets.Length];
        isActiveState = new bool[targets.Length];

        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i] != null)
            {
                targetPositions[i] = targets[i].transform.position;
                isActiveState[i] = targets[i].activeSelf;
            }
        }
    }

    private void Start()
    {
        CheckAllTargets();
    }

    private void FixedUpdate() // 매 프레임 체크. 부담되면 0.1~0.2초 주기로 바꿔도 됨
    {
        CheckAllTargets();
    }

    private void CheckAllTargets()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            if (targets[i] == null) continue;

            bool isInRange = rangeCollider.OverlapPoint(targetPositions[i]);

            if (isInRange != isActiveState[i])
            {
                targets[i].SetActive(isInRange);
                isActiveState[i] = isInRange;
            }
        }
    }
}