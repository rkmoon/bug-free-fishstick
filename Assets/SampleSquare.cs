﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TbsFramework.Cells;

public class SampleSquare : Square
{
    public override Vector3 GetCellDimensions()
    {
        return GetComponent<Renderer>().bounds.size;
    }

    public override void MarkAsHighlighted()
    {
        GetComponent<Renderer>().material.color = new Color(0.75f, 0.74f, 0.74f);
    }

    public override void MarkAsPath()
    {
        GetComponent<Renderer>().material.color = Color.green;
    }

    public override void MarkAsReachable()
    {
        GetComponent<Renderer>().material.color = Color.yellow;
    }

    public override void UnMark()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
