﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapData : MonoBehaviour
{
    public int width = 10;
    public int height = 5;

    void Start()
    {
        
    }

    public int[,] MakeMap()
    {
        int[,] map = new int[width, height];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                map[x, y] = 0;
            }
        }

        map[1, 0] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;
        map[1, 3] = 1;
        map[5, 5] = 1;
        map[6, 5] = 1;
        map[7, 4] = 1;

        return map;
    }
}
