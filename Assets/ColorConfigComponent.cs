using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ColorConfigComponent : MonoBehaviour {

    private ColorConfigComponent() {}

    public ReactiveProperty<Color> colorConfig = new ReactiveProperty<Color>();

    public static ColorConfigComponent Instance
    {
        get
        {
            var instance = new ColorConfigComponent();  
            return instance;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
