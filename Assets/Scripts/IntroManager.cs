using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroManager : MonoBehaviour
{
    public LevelChanger levelChanger;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadNextScene", 5f);
    }

    private void LoadNextScene()
    {
        levelChanger.FadeToLevel(1);
    }
}
