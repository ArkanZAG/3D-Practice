using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using EXP_scene;
using UnityEngine;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerData playerData = new();

    public float CurrentExperience => playerData.currentExperience;
    public float CurrentLevel => playerData.currentLevel;

    public void AddExperience(float delta)
    {
        playerData.currentExperience += delta;

        if (playerData.currentExperience >= playerData.maxExperience)
        {
            playerData.currentLevel += 1;
            playerData.maxExperience += 10;
            playerData.currentExperience = 0;
        }
    }

    public void AddLevel(float delta)
    {
        playerData.currentLevel += delta;
    }

    public void AddexperienceFunction()
    {
        AddExperience(10);
    }
    public void AddLevelFunction()
    {
        AddLevel(1);
    }

    public void SaveGame()
    {
        var json = JsonConvert.SerializeObject(playerData);
        File.WriteAllText(Application.persistentDataPath + "/Savefile.json", json);
    }
    private void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/Savefile.json"))
        {
            string savedFile = File.ReadAllText(Application.persistentDataPath + "/Savefile.json");
            playerData = JsonConvert.DeserializeObject<PlayerData>(savedFile);
        }

        Application.quitting += SaveGame;
    }
}
