using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonSaving : MonoBehaviour
{
    private JSONParser JsonData;
    private string path = "";
    private string persistentPath = "";


    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void CreatePlayerData()
    {
        JsonData = new JSONParser();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
