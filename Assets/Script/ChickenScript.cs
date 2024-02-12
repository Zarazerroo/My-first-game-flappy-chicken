using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenScript : MonoBehaviour
{
    public Rigidbody2D myRigibody;
    public float flapStrength;
    public LogicScript logic;
    public bool chickenIsAlive = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)== true && chickenIsAlive == true )
        {
            myRigibody.velocity = Vector2.up * flapStrength;
          
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        chickenIsAlive = false;
    }
   

}
