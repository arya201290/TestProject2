using UnityEngine;
using System.Collections;

public class Scene_LeanTween : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start ()
    {
        print("Start!");
        if(obj != null)
        { 
            LeanTween.move(obj, new Vector3[] { new Vector3(0f, 0f, 0f),
                                                new Vector3(3.3f, 0f, 3.3f),
                                                new Vector3(6.6f, 0f, 6.6f),
                                                new Vector3(10f, 0f, 10f) }, 1.5f)
                //.setEase(LeanTweenType.easeOutQuad)
                .setOrientToPath(true);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
