using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // Serialize for Debugging

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
    public void RemoveBreakableBlocks()
    {
        breakableBlocks--;
    }
}

