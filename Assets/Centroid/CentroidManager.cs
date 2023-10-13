using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentroidManager : MonoBehaviour
{
    public DragablePoint A;
    public DragablePoint B;
    public DragablePoint C;

    public GameObject AB;
    public GameObject AC;
    public GameObject BC;

    private LineRenderer lrAB;
    private LineRenderer lrAC;
    private LineRenderer lrBC;

    private LinearFunction fab = new LinearFunction(1, 1);
    private LinearFunction fac = new LinearFunction(1, 1);
    private LinearFunction fbc = new LinearFunction(1, 1);

    public GameObject hAB;
    public GameObject hAC;

    private LinearFunction ChAB = new LinearFunction(1, 1);
    public GameObject chab;
    private LineRenderer lchab;


    void Start()
    {
        lrAB = AB.GetComponent<LineRenderer>();
        lrAC = AC.GetComponent<LineRenderer>();
        lrBC = BC.GetComponent<LineRenderer>();
        lchab =chab.GetComponent<LineRenderer>();

    }

    void Update()
    {
        hAB.transform.position = new Vector3((A.transform.position.x +B.transform.position.x)/2.0f , (A.transform.position.y+ B.transform.position.y) / 2.0f, 0);
        hAC.transform.position = new Vector3((A.transform.position.x + C.transform.position.x) / 2.0f, (A.transform.position.y + C.transform.position.y) / 2.0f, 0);

        fab.LineTroughTwoPoint(A.transform.position, B.transform.position);
        lrAB.SetPosition(0, new Vector3(-10,fab.GetY(-10), 0));
        lrAB.SetPosition(1, new Vector3(10, fab.GetY(10), 0));

        fac.LineTroughTwoPoint(A.transform.position, C.transform.position);
        lrAC.SetPosition(0, new Vector3(-10, fac.GetY(-10), 0));
        lrAC.SetPosition(1, new Vector3(10, fac.GetY(10), 0));

        fbc.LineTroughTwoPoint(B.transform.position, C.transform.position);
        lrBC.SetPosition(0, new Vector3(-10, fbc.GetY(-10), 0));
        lrBC.SetPosition(1, new Vector3(10, fbc.GetY(10), 0));

        // function line C and half AB
        ChAB.LineTroughTwoPoint(C.transform.position, hAB.transform.position);
        lchab.SetPosition(0, new Vector3(-10, ChAB.GetY(-10), 0));
        lchab.SetPosition(1, new Vector3(10, ChAB.GetY(10), 0));

    }
}
