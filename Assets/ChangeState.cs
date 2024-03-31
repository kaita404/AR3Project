using UnityEngine;

public class ChangeState : MonoBehaviour
{
    private int currentState = 0;
    private Animator animator; // Reference to the Animator component

    void Start()
    {
        animator = GetComponent<Animator>(); // Get the Animator component attached to the GameObject
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 is the left mouse button
        {
            ChangeState1();
        }
    }

    void ChangeState1()
    {
        currentState = (currentState + 1) % 3; // Cycles through states 0, 1, 2
        Debug.Log("Current State: " + currentState);

        // Trigger the corresponding animation for each state
        switch (currentState)
        {
            case 0:
                animator.SetTrigger("State0Animation");
                break;
            case 1:
                animator.SetTrigger("State1Animation");
                break;
            case 2:
                animator.SetTrigger("State2Animation");
                break;
        }
    }
}
