using UnityEngine;
using AppKit;

public class ArduinoSerialTest : MonoBehaviour
{
    ArduinoSerial serial;

    void Start()
    {
        serial = ArduinoSerial.Instance;
        serial.OnDataReceived += OnSerialReceived;
        serial.Open(null, ArduinoSerial.Baudrate.B_9600);
    }

    void OnDestroy()
    {
        serial.OnDataReceived -= OnSerialReceived;
    }

    void OnSerialReceived(string msg)
    {
        Debug.LogFormat("msg: {0}", msg);
    }
}
