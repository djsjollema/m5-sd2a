using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearFunction
{
    public float slope;
    public float intercept;

    public LinearFunction(float slope, float intercept)
    {
        this.slope = slope;
        this.intercept = intercept;
    }
    
    public float GetY(float x)
    {
        return x*slope + intercept;
    }

    public void LineTroughTwoPoint(Vector3 A, Vector3 B)
    {
        this.slope = (B.y - A.y)/(B.x - A.x);
        this.intercept = B.y - this.slope * B.x;
    }

    public Vector3 intesection(LinearFunction m)
    {
        Vector3 intersectionPoint = new Vector3(0,0,0);
        float intersection_x = (m.intercept - this.intercept)/(this.slope - m.slope);
        float intersection_y = this.slope * intersection_x + this.intercept;
        intersectionPoint.x = intersection_x;
        intersectionPoint.y = intersection_y;
        return intersectionPoint;
    }
}
