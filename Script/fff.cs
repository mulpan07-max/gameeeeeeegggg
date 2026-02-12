using UnityEngine;

public class fff : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MusicManager.instance.PlayMusic(MusicManager.instance.mainMenuMusic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
