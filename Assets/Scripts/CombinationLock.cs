using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombinationLock : MonoBehaviour
{
    [SerializeField] private GameObject lockedObject;

    [SerializeField] private GameObject roller1;
    [SerializeField] private int roller1Answer;
    [SerializeField] private GameObject roller2;
    [SerializeField] private int roller2Answer;
    [SerializeField] private GameObject roller3;
    [SerializeField] private int roller3Answer;
    [SerializeField] private GameObject roller4;
    [SerializeField] private int roller4Answer;


    // Start is called before the first frame update
    private void Start()
    {
        //interactionWithItem = GetComponent<InteractionWithItem>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CheckCombo()
    {
        print("click");

        CombinationRoller roller1Script = roller1.GetComponent<CombinationRoller>();
        int roller1State = roller1Script.rollerState;
        CombinationRoller roller2Script = roller2.GetComponent<CombinationRoller>();
        int roller2State = roller2Script.rollerState;
        CombinationRoller roller3Script = roller3.GetComponent<CombinationRoller>();
        int roller3State = roller3Script.rollerState;
        CombinationRoller roller4Script = roller4.GetComponent<CombinationRoller>();
        int roller4State = roller4Script.rollerState;

        if (roller1State == roller1Answer && 
            roller2State == roller2Answer && 
            roller3State == roller3Answer && 
            roller4State == roller4Answer)
        {
            print("correct");

            InteractionWithItem interactionWithItem = lockedObject.GetComponent<InteractionWithItem>();
            interactionWithItem.InteractionFunction();
        }

    }
}
