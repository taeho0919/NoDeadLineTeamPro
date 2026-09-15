using UnityEngine;

[RequireComponent(typeof(KTH_InteractionChecker))]
public class KTH_PlayerInteractor : MonoBehaviour
{
    [SerializeField]private KTH_InteractionChecker itChecker;
    [SerializeField] private KeyCode interactKey = KeyCode.F;
    
    
    private void Awake()
    {
        if(itChecker==null)
            itChecker=GetComponent<KTH_InteractionChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!itChecker)return;
        if(KTH_InputLock.instance.IsLocked)return;

        if(Input.GetKeyDown(interactKey))
            itChecker.TryInteract();
    }
}
