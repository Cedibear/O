using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Player
{
    public String playerName;
    public int overall;
    public bool isInjured;
    public SpecialAbility specialAbility;
    public EmotionManager.Emotion emotion;
    public float energy;
}

[System.Serializable]
public class Team
{
    public String teamName;
    public List<Player> players = new List<Player>();
}