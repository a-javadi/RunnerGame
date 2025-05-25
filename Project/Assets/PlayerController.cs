using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator animCharacter;
    // Start is called before the first frame update
    void Start()
    {
        animCharacter = this.GetComponent<Animator>();
    }

    // This function is called when the player lands
    void stopJumping()
    {
        animCharacter.SetBool("isJumping", false);
    }

    void stopMagic()
    {
        animCharacter.SetBool("isMagic", false);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            animCharacter.SetBool("isJumping", true);
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            animCharacter.SetBool("isMagic" , true);
        }   
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.Rotate(Vector3.up * 90);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.Rotate(Vector3.up * -90);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.Translate(-0.1f , 0 , 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.Translate(0.1f , 0 , 0);
        }

    }


}
 