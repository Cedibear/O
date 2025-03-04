using UnityEngine;
using System.Collections.Generic;

public class TacticsManager : MonoBehaviour
{
    public Dictionary<String, String> formations;
    public Dictionary<String, String> tactics;

    void Start()
    {
        InitializeFormations();
        InitializeTactics();
    }

    void InitializeFormations()
    {
        formations = new Dictionary<String, String>
        {
            { "4-4-2", "4 defenders, 4 midfielders, 2 strikers" },
            { "4-3-3", "4 defenders, 3 midfielders, 3 strikers" },
            // Add more formations
        };
    }

    void InitializeTactics()
    {
        tactics = new Dictionary<String, String>
        {
            { "High Press", "Press the opponent high up the pitch" },
            { "Counter Attack", "Quick transitions from defense to attack" },
            // Add more tactics
        };
    }

    public void SetFormation(String formation)
    {
        // Apply the selected formation
    }

    public void SetTactic(String tactic)
    {
        // Apply the selected tactic
    }
}