﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapSpace
{
    public enum Immovables { Space, Open_Door, Stairs_Up, Stairs_Down, Wall, Closed_Door }

    public Immovables thisIs = Immovables.Space;



    List<Item> ItemsHere;
    CharacterControl CharacterHere;
    Creature EnemyHere;
    private bool isVisible = false;

    public bool isEmpty { get { return thisIs == Immovables.Space; }  }

    public mapSpace(Immovables wall)
    {
        thisIs = wall;
        ItemsHere = new List<Item>();

    }

    internal bool containsMonster()
    {
        return EnemyHere != null;
    }

    internal bool canMoveTo()
    {
        if (EnemyHere != null) return false;

        return thisIs < Immovables.Wall;
    }


    internal void  makeVisible(ItemsControl itemManger)
    {
        if (!isVisible)
        {
            isVisible = true;
            generateItemGOHere(itemManger);
        }
    }


    private void generateItemGOHere(ItemsControl itemManager)
    {
       foreach (Item newItem in ItemsHere)
        {
            accessItem newitemScript = itemManager.createItemGO(newItem);
            
        }
    }

    internal Creature getMonster()
    {
        return EnemyHere;
    }
    internal void place(Item item)
    {
        ItemsHere.Add(item);

    }


    internal void AddMonster(Creature newMonster)
    {
        EnemyHere = newMonster;
}



}
