using UnityEngine;

public class CrowdManager : MonoBehaviour
{
    public AudioClip[] crowdChants;
    public AudioClip[] crowdCheers;
    public AudioClip[] crowdBoos;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlayAmbience();
    }

    public void PlayAmbience()
    {
        audioSource.clip = crowdChants[Random.Range(0, crowdChants.Length)];
        audioSource.loop = true;
        audioSource.Play();
    }

    public void PlayCheer()
    {
        audioSource.PlayOneShot(crowdCheers[Random.Range(0, crowdCheers.Length)]);
    }

    public void PlayBoo()
    {
        audioSource.PlayOneShot(crowdBoos[Random.Range(0, crowdBoos.Length)]);
    }

    public void ReactToEvent(String eventType)
    {
        switch (eventType)
        {
            case "Goal":
                PlayCheer();
                break;
            case "Foul":
                PlayBoo();
                break;
            // Add more reactions
        }
    }
}