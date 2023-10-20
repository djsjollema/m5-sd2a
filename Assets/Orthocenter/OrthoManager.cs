using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrthoManager : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public DragablePoint C;
    private LinearFunction functionLineAB = new LinearFunction(1, 2);
    public LineRenderer lineAB;


    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        functionLineAB.LineTroughTwoPoint(A.transform.position, B.transform.position);
        lineAB.SetPosition(0, new Vector3(-20, functionLineAB.GetY(-20), 0));
        lineAB.SetPosition(1, new Vector3(20, functionLineAB.GetY(20), 0));


    }
}
