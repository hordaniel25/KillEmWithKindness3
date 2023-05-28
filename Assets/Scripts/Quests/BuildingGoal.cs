using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingGoal : Quest.QuestGoal
{
    public string Building;

    public override string GetDescription()
    {
        return $"Build a {Building}";
    }

    public override void Initialize()
    {
        base.Initiialize();
        EventManager.Instance.AddListener<BuildingEvnt>(OnBuilding);
    }

    private void OnBuilding(BuildingGameEvent eventInfo)
    {
        if (eventInfo.BuildingName == Building)
        {
            CurrentAmount++
            Evaluate();
        }
    }
}
