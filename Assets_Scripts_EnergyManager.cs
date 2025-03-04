using UnityEngine;

public class EnergyManager : MonoBehaviour
{
    public float maxEnergy = 100f;
    public float currentEnergy;
    public float energyDrainRate = 1f;
    public float energyRecoveryRate = 0.5f;

    void Start()
    {
        currentEnergy = maxEnergy;
    }

    void Update()
    {
        ManageEnergy();
    }

    void ManageEnergy()
    {
        // Drain energy during gameplay
        currentEnergy -= energyDrainRate * Time.deltaTime;

        // Recover energy when resting
        if (currentEnergy < maxEnergy)
        {
            currentEnergy += energyRecoveryRate * Time.deltaTime;
        }

        // Implement effects of low energy on player performance
    }
}