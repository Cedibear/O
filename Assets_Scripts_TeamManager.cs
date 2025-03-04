using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour
{
    public List<Team> teams = new List<Team>();

    void Start()
    {
        GenerateRandomTeams();
    }

    void GenerateRandomTeams()
    {
        for (int i = 0; i < 20; i++)
        {
            Team team = new Team();
            team.teamName = "Team " + (i + 1);
            for (int j = 0; j < 11; j++)
            {
                Player player = new Player();
                player.playerName = "Player " + (j + 1);
                player.overall = Random.Range(70, 96);
                player.isInjured = false;
                player.specialAbility = AssignSpecialAbility(player.overall);
                player.emotion = EmotionManager.Emotion.Neutral;
                player.energy = 100f;
                team.players.Add(player);
            }
            teams.Add(team);
        }
    }

    SpecialAbility AssignSpecialAbility(int overall)
    {
        if (overall >= 90)
        {
            int abilityIndex = Random.Range(1, 5); // Exclude 'None'
            return (SpecialAbility)abilityIndex;
        }
        return SpecialAbility.None;
    }
}