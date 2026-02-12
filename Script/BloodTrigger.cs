using UnityEngine;

public class BloodTrigger : MonoBehaviour
{
    // —юда мы перетащим наш объект Blood
    public GameObject bloodObject;

    public void OnButtonClick()
    {
       
        bloodObject.SetActive(true);

        
        Animator anim = bloodObject.GetComponent<Animator>();
        if (anim != null)
        {
            anim.Play("BloodFlow", -1, 0f);
        }
    }
}