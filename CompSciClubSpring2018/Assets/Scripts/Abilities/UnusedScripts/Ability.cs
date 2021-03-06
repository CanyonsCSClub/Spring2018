﻿/* Ability.cs
 * Date Created: 3/7/18
 * Last Edited: 3/7/18
 * Programmer: Jack Bruce
 * Description: Parent class for all abilities.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//I don't know if its a good idea to inherit MonoBehavior
public class Ability : MonoBehaviour{

    private BasicObjectInformation objectInfo;
    private List<AbilityBehaviors> behaviors;

    private bool requiresTarget; // might not need these
    private bool canCastOnself;  // ""

    private float cooldown; //secs
    private GameObject particleEffect; //needs assigned when we create the abiltiy
    private float castTime; // secs
    private float cost;
    private AbilityType type;

    public enum AbilityType //ID's for different spell types
    {
        Ice,
        Earth,
        Wind,
        Astral
    }

    public Ability(BasicObjectInformation aBasicInfo)
    {
        objectInfo = aBasicInfo;
        behaviors = new List<global::AbilityBehaviors>();
        cooldown = 0f;
        requiresTarget = false;
        canCastOnself = false;
    }

    public Ability(BasicObjectInformation aBasicInfo, List<AbilityBehaviors> abehaviors) {
        objectInfo = aBasicInfo; 
        behaviors = new List<AbilityBehaviors>();
        behaviors = abehaviors;
        cooldown = 0f;
        requiresTarget = false;
        canCastOnself = false;
    }

    public Ability(BasicObjectInformation aBasicInfo, List<AbilityBehaviors> abehaviors, bool arequiresTarget, float acooldown, GameObject aparticleE)
    {
        objectInfo = aBasicInfo;
        behaviors = new List<AbilityBehaviors>();
        behaviors = abehaviors;
        cooldown = acooldown;
        requiresTarget = arequiresTarget;
        canCastOnself = false;
        particleEffect = aparticleE;


    }

    public BasicObjectInformation AbilityInfo
    {
        get { return objectInfo; }
    }

    public float AbilityCoolDown
    {
        get { return cooldown; }
    }

    public List<AbilityBehaviors> AbilityBehaviors {
        get { return behaviors; }
    }

    //This is the method that will be called anytime we us ability
    public virtual void UseAbility() 
    {
        
    }


}
