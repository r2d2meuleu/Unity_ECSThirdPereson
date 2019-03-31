﻿using System.Collections.Generic;
using Unity.Burst;
using Unity.Collections;
using Unity.Entities;
using Unity.Jobs;
using Unity.Transforms;
using Unity.Mathematics;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine;

[System.Serializable]
public struct SpawnPoint : ISharedComponentData
{
    public bool spawnAsPlayer;
    public GameObject sourceGameObject;
}

public class SpawnPointComponent : SharedComponentDataProxy<SpawnPoint> { } 