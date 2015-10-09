using UnityEngine;
using System.Collections;

public class Scene_Spline : MonoBehaviour {

    public BezierCurve bezierCurve;
    public BezierPoint bezierPoint;

	// Use this for initialization
	void Start () {
        print("Start!");

        print(bezierCurve.pointCount);
        print(bezierCurve.GetAnchorPoints());
        print(bezierPoint.position);
        print(bezierPoint.localPosition);

        print((float)bezierPoint.globalHandle1.x);
        print((float)bezierPoint.handle1.x);
        print((float)bezierPoint.globalHandle2.x);
        print((float)bezierPoint.handle2.x);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
