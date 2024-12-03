using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class TweenDemo1 : MonoBehaviour
{

    [SerializeField]
    private Transform demoCube;

    void Start()
    {
        // transform.DOMoveX(10f, 2f);
        transform.DOMoveX(10f, 2f)
            .SetEase(Ease.InBounce)
            .SetLoops(-1, LoopType.Yoyo);
        demoCube.DORotate(new Vector3(0, 180, 0), 1f)
            .SetEase(Ease.InOutQuad)
            .SetLoops(-1);
    }

    void Update()
    {
        
    }
}
