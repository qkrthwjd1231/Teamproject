using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class name : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField InputText;

    public void Test(Text text)
    {
        text.text = InputText.text;
    }
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
