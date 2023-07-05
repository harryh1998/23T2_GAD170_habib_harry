using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Update()
    {
        //Move our object based on input from the player
        //we'll need an IF STATMENT when we want to get the player input
    
       //EXAMPLE....
      int playerScore=1;
      playerScore++;
      playerScore=playerScore+ 1;

      //transform position++; DOESN'WORK
      Vector3 moveDirection = Vector3.forward;
      transform.position   = transform.position+moveDirection;
        transform.position = moveDirection;

       //when player presses arrow keys (or WASD)....
       //....the gameobject moves in the respective direction

      // we need to CREATE A VECTOR
      // X, Y,Z

      // if "pressing D",then move +X
      if (Input.GetKey (KeyCode.D))
      
              transform.position+= Vector3.right;

        //if pressing A",then move -X
        if (Input.GetKey(KeyCode.A))

            transform.position += Vector3.left;

        //no jump... so no +Y or -Y
        // if "pressing W",then move +Z
        // if pressing S", then move -Z



        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime, 0, Input.GetAxis("Vertical") * Time.deltaTime);





    }

    // Update is called once per frame
    
   
        
    
}
