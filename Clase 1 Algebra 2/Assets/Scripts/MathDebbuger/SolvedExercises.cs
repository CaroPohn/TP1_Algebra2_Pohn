using CustomMath;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolvedExercises : MonoBehaviour
{
    [SerializeField] private int exerciseNumber = 1;
    
    [SerializeField] private Vec3 vectorA;
    [SerializeField] private Vec3 vectorB;
    [SerializeField] private Vec3 vectorC;

    private void Update()
    {
        switch (exerciseNumber)
        {
            case 1:
                {
                    vectorC = Exercise1();
                    break;
                }
            case 2:
                {
                    break;
                }
            case 3:
                {
                    break;
                }
            case 4:
                {
                    break;
                }
            case 5:
                {
                    break;
                }
            case 6:
                {
                    break;
                }
            case 7:
                {
                    break;
                }
            case 8:
                {
                    break;
                }
            case 9:
                {
                    break;
                }
            case 10:
                {
                    break;
                }
        }
    }

    private Vec3 Exercise1()
    {
        return vectorA + vectorB;
    }

    private void OnDrawGizmos()
    {
        Vector3 showVectorA = vectorA;
        Vector3 showVectorB = vectorB;
        Vector3 showVectorC = vectorC;

        Gizmos.color = Color.magenta;
        Gizmos.DrawLine(transform.position, transform.position + vectorA);

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(transform.position, transform.position + vectorB);

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(transform.position, transform.position + vectorC);
    }
}
