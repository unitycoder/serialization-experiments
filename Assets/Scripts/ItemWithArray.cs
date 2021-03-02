﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemWithArray : MonoBehaviour, ISerializableItem
{
    public string PrefabName => "item_with_array";

    [System.Serializable]
    public class Data : ISerializableData
    {
        public int[] array;

    }

    public Data data;
    public ISerializableData SerializedData { get => data; set => data = value as Data; }
}
