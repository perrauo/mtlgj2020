﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.Tilemaps.T

public enum TileID
{
    Start,
    End,
    Full,
}


public class GGJTile : IsometricRuleTile
{

    [SerializeField]
    public TileID ID;

}
