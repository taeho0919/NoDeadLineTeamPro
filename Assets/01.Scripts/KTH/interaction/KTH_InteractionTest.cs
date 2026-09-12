using System;
using UnityEngine;

public class KTH_InteractionTest : MonoBehaviour
{
    [SerializeField]private KTH_InteractionChecker itChecker;

    private void Awake()
    {
        if(itChecker==null)
            itChecker=GetComponent<KTH_InteractionChecker>();
    }

    // Update is called once per frame
    void Update()
    {
        Test(itChecker.isInteracting);
    }

    private void Test(bool isInteracting)
    {
        Debug.Log(isInteracting);
    }
}
