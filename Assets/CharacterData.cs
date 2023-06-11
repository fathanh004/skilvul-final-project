using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Data", menuName = "ScriptableObjects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public Sprite charSprite;
    public RuntimeAnimatorController animatorController;
}
