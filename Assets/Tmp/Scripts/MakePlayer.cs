﻿using UnityEditor;
using UnityEngine;
using System.Collections;

public static class MakePlayer {

    [MenuItem("Component/Make Player")]
    public static void Do()
    {
        if (Selection.activeGameObject == null) return;
        Debug.Log(Selection.activeGameObject.name);

        if (Selection.activeGameObject.GetComponent<Move>() == null)
        {
            var move = Selection.activeGameObject.AddComponent<Move>();
            move.Speed = 5;
        }
        if (Selection.activeGameObject.GetComponent<Fire>() == null)
        {
            var fire = Selection.activeGameObject.AddComponent<Fire>();
            fire.RocketPrefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/Ready/Rocket Ready 06.prefab", typeof(GameObject)) as GameObject;
        }
        if (Selection.activeGameObject.GetComponent<PlayerDeath>() == null)
        {
            Selection.activeGameObject.AddComponent<PlayerDeath>();
        }
        if (Selection.activeGameObject.GetComponent<BoxCollider>() == null)
        {
            var c = Selection.activeGameObject.AddComponent<BoxCollider>();
            c.isTrigger = true;  
        }
    }

}
