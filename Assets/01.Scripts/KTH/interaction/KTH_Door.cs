using UnityEngine;

public class KTH_Door : MonoBehaviour, KTH_IInteraction
{
    
    public void OnInteractionEnter()
    {
        Debug.Log("범위 안으로 들어옴");
    }

    public void OnInteractionExit()
    {
        Debug.Log("범위 밖으로 나감");
    }

    public void Interact()
    {
        Debug.Log("문 동작 실행");
        
    }
}
