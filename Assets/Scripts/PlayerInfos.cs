using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfos : MonoBehaviour
{
    private static int nbPoints = 0;
    private static int nbHearts = 3;
    private static int nbMiss = 0;

    public static int getNbPoints()
    {
        return nbPoints;
    }

    public static void setNbPoints(int _nbPoints)
    {
        nbPoints = _nbPoints;
    }

    public static void addNbPoints(int _nbPoints)
    {
        nbPoints += _nbPoints;
    }

    public static int getNbHearts()
    {
        return nbHearts;
    }

    public static void setNbHearts(int _nbHearts)
    {
        nbHearts = _nbHearts;
    }

    public static void removeOneHeart()
    {
        nbHearts -= 1;
    }

    public static int getNbMiss()
    {
        return nbMiss;
    }

    public static void incrementNbMiss()
    {
        nbMiss += 1;
    }
}
