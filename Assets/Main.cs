using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class Main : MonoBehaviour {

    SerialPort stream = new SerialPort("COM8", 9600);

    // Use this for initialization
    void Start()
    {
        stream.Open();
    }

    // Update is called once per frame
    void Update()
    {
        string value = stream.ReadLine();
        string[] vec3 = value.Split(',');
        GetComponent<Renderer>().material.color = new Color(float.Parse(vec3[0])/255, float.Parse(vec3[1])/255, float.Parse(vec3[2])/255, float.Parse(vec3[3])/255);
    }
}
