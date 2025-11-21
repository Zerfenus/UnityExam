using UnityEngine;

public class MoveAnim : MonoBehaviour
{
    Animator MovementAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MovementAnimator = GetComponent<Animator>();
        
        MovementAnimator.SetBool("Moving", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MovementAnimator.SetBool("Moving", true);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    MovementAnimator.SetBool("Moving", true);
                }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            MovementAnimator.SetBool("Moving", false);
        }
    }
}
