using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelScore : MonoBehaviour
{
    public static int score = 5;
    public static void ReduceScore() =>  score -= 1;
}
