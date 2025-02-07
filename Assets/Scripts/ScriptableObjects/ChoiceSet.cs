using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChoiceSet : ScriptableObject
{
    [SerializeField] private string _choiceSetName;
    [SerializeField] private Enums.CivilizationPhase _choicePhase;
    [SerializeField] private BasicChoice[] _choices; //set of choices available in this set

    public string ChoiceSetName { get => _choiceSetName; set => _choiceSetName = value; }
    public Enums.CivilizationPhase ChoicePhase { get => _choicePhase; set => _choicePhase = value; }
    public BasicChoice[] Choices { get => _choices; set => _choices = value; }
}
