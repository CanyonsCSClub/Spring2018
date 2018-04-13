﻿/*
 * 
 * Author: Spencer Wilson
 * Date Created: 3/23/2018 @ 11:59 am
 * Date Modified: 3/23/2018 @ 9:48 pm
 * Project: CompSciClubSpring2018
 * File: GroundCheck.cs
 * Description: Checks if the player is colliding with the ground or not.
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{

    public GameObject character; // Public game object named character that holds the reference to the attached character. 
    // Use this for initialization
    private void Start()
    {

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
            if (character.gameObject.name == "Human")
            {
                character.GetComponent<HumanJump>().SetIsGrounded(false);
                character.GetComponent<HumanMovement>().SetIsGrounded(false);
        }
            else if (character.gameObject.name == "Ferrox")
            {
                character.GetComponent<FerroxJump>().SetIsGrounded(false);
                //character.GetComponent<FerroxMovement>().SetIsGrounded(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platforms")
        {
            if (character.gameObject.name == "Human")
            {
                character.GetComponent<HumanJump>().SetIsGrounded(true);
                character.GetComponent<HumanMovement>().SetIsGrounded(true);
            }
            else if (character.gameObject.name == "Ferrox")
            {
                character.GetComponent<FerroxJump>().SetIsGrounded(true);
                //character.GetComponent<FerroxMovement>().SetIsGrounded(true);
            }
        }
    }
}
