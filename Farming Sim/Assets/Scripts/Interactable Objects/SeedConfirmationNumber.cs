using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedConfirmationNumber : MonoBehaviour
{
    SeedConfirmation seedConfirmation;
    SeedTracker seedTracker;

    public int max = 20;
    public int maxSeed = 0;

    private void Start()
    {
        seedConfirmation = GameObject.FindObjectOfType<SeedConfirmation>();
        seedTracker = GameObject.FindObjectOfType<SeedTracker>();
    }

    public void MinusTen()
    {
        if (seedConfirmation.number > 10)
        {
            seedConfirmation.number -= 10;
        }
    }
    public void MinusFive()
    {
        if (seedConfirmation.number > 5)
        {
            seedConfirmation.number -= 5;
        }
    }
    public void MinusOne()
    {
        if (seedConfirmation.number > 1)
        {
            seedConfirmation.number -= 1;
        }
    }
    public void PlusOne()
    {
        maxSeed = seedTracker.amount;
        if (seedConfirmation.number < max && seedConfirmation.number < maxSeed)
        {
            seedConfirmation.number += 1;
        }
    }
    public void PlusFive()
    {
        maxSeed = seedTracker.amount;
        if (seedConfirmation.number < max-4 && seedConfirmation.number < maxSeed-4)
        {
            seedConfirmation.number += 5;
        }
        else
        {
            seedConfirmation.number = max;
        }
    }
    public void PlusTen()
    {
        maxSeed = seedTracker.amount;
        if (seedConfirmation.number < max-9 && seedConfirmation.number < maxSeed-9)
        {
            seedConfirmation.number += 10;
        }
        else
        {
            seedConfirmation.number = max;
        }
    }
}
