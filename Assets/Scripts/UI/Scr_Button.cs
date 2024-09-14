using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scr_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public UI_update ui_update;

    public void OnClick(){
        if(ui_update != null){ui_update.Controls_parse(name, 1);}
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
