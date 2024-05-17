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

    private float timeCounter = 0.0f;

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
                    vectorC = Exercise2();
                    break;
                }
            case 3:
                {
                    vectorC = Exercise3();
                    break;
                }
            case 4:
                {
                    vectorC = Exercise4();
                    break;
                }
            case 5:
                {
                    vectorC = Exercise5();
                    break;
                }
            case 6:
                {
                    vectorC = Exercise6();
                    break;
                }
            case 7:
                {
                    vectorC = Exercise7();
                    break;
                }
            case 8:
                {
                    vectorC = Exercise8();
                    break;
                }
            case 9:
                {
                    vectorC = Exercise9();
                    break;
                }
            case 10:
                {
                    vectorC = Exercise10();
                    break;
                }
        }
    }

    private Vec3 Exercise1()
    {
        return vectorA + vectorB;
    }

    private Vec3 Exercise2()
    {
        return vectorB - vectorA;
    }

    private Vec3 Exercise3()
    {
        Vec3 result = vectorA;
        result.Scale(vectorB);

        return result;
    }

    private Vec3 Exercise4()
    {
        return Vec3.Cross(vectorB, vectorA);
    }

    private Vec3 Exercise5()
    {
        float duration = 1.0f;
        timeCounter += Time.deltaTime;

        if (timeCounter >= duration)
            timeCounter = 0.0f;

        return Vec3.Lerp(vectorA, vectorB, timeCounter);
    }

    private Vec3 Exercise6()
    {
        return Vec3.Max(vectorA, vectorB);
    }

    private Vec3 Exercise7()
    {
        return Vec3.Project(vectorA, vectorB);
    }

    private Vec3 Exercise8()
    {
        Vec3 result = Vec3.Lerp(vectorA, vectorB, 0.5f);
        result.Normalize();

        Vec3 scaledResult = result * Vec3.Distance(vectorA, vectorB);

        return scaledResult;
    }

    private Vec3 Exercise9()
    {
        vectorB.Normalize();

        return Vec3.Reflect(vectorA, vectorB);
    }

    private Vec3 Exercise10()
    {
        float duration = 10.0f;
        timeCounter += Time.deltaTime;

        if (timeCounter >= duration)
            timeCounter = 0.0f;

        return Vec3.LerpUnclamped(vectorB, vectorA, timeCounter);
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
