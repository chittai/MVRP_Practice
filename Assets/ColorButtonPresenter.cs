using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UnityEngine.UI;

public class ColorButtonPresenter : MonoBehaviour {

    [SerializeField] Button redButton;
    [SerializeField] Button blueButton;
    [SerializeField] Button yellowButton;

    void Start () {
        var colorConfig = ColorConfigComponent.Instance;

        var material = GetComponent<Renderer>().material;

        var redColorStream = redButton.OnClickAsObservable().Select(_=> Color.red);
        var blueColorStream = blueButton.OnClickAsObservable().Select(_ => Color.blue);
        var yellowColorStream = yellowButton.OnClickAsObservable().Select(_ => Color.yellow);

        ///<Summary>
        ///Model → View への反映
        ///</Summary>
        colorConfig.colorConfig
            .Subscribe(c => material.color = c);

        ///<Summary>
        ///View → Model への反映
        ///</Summary>
        redColorStream
            .Subscribe(c => colorConfig.colorConfig.Value = c );

        blueColorStream
            .Subscribe(c => colorConfig.colorConfig.Value = c);

        yellowColorStream
            .Subscribe(c => colorConfig.colorConfig.Value = c);
    }
}
