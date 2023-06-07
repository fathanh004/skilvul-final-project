using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu(fileName = "Character Data", menuName = "ScriptableObjects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public Sprite charSprite;
    public AnimatorController animatorController;
}
