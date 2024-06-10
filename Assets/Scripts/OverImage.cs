using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverImage : MonoBehaviour
{
    public RectTransform panelRectTransform;

    // Start is called before the first frame update
    void Start()
    {
        panelRectTransform.SetAsLastSibling();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
