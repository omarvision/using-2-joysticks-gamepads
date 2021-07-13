using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//GamePad Mappings:  http://wiki.etc.cmu.edu/unity3d/index.php/Joystick/Controller
// [XBox 360 Controller] & [Logitech GamePad F310] have same input manager mappings

public class Joystick : MonoBehaviour
{
    #region --- helpers ---
    [System.Serializable]
    public class TextJoystick
    {
        public Text txtLT;
        public Text txtLB;
        public Text txtRT;
        public Text txtRB;
        public Text txtBack;
        public Text txtStart;
        public Text txtLeftAnalogX;
        public Text txtLeftAnalogY;
        public Text txtRightAnalogX;
        public Text txtRightAnalogY;
        public Text txtA;
        public Text txtB;
        public Text txtX;
        public Text txtY;
        public Text txtDPadX;
        public Text txtDPadY;
        public Text txtLeftAnalogPress;
        public Text txtRightAnalogPress;
    }
    #endregion

    public Text txtTitle;
    public TextJoystick joy1 = new TextJoystick();
    public TextJoystick joy2 = new TextJoystick();

    private void Start()
    {
        string names = "";
        int cnt = 0;
        string[] joysticknames = Input.GetJoystickNames();
        foreach (string name in joysticknames)
        {
            cnt += 1;
            if (cnt > 1)
                names += ", ";
            names += cnt.ToString() + ". " + name;
            Debug.Log(names);
        }
        txtTitle.text = "Joysticks : " + names;
    }
    private void Update()
    {
        ReadingJoystick1();
        ReadingJoystick2();
    }
    private void ReadingJoystick1()
    {
        //LT is the positive values of the 3rd axis (Left Trigger)
        float LT = Input.GetAxis("LT1");
        LT = (LT > 0) ? LT : 0;

        //RT is the negative values of the 3rd axis (RightTrigger)
        float RT = Input.GetAxis("RT1");
        RT = (RT < 0) ? RT : 0;

        //18 inputs from joystick
        joy1.txtLT.text = "LT : " + LT.ToString();
        joy1.txtLB.text = "LB : " + Input.GetButton("LB1").ToString();
        joy1.txtRT.text = "RT : " + RT.ToString();
        joy1.txtRB.text = "RB : " + Input.GetButton("RB1").ToString();
        joy1.txtBack.text = "Back : " + Input.GetButton("Back1").ToString();
        joy1.txtStart.text = "Start : " + Input.GetButton("Start1").ToString();
        joy1.txtLeftAnalogX.text = "LeftAnalogX : " + Input.GetAxis("LeftAnalogX1").ToString();
        joy1.txtLeftAnalogY.text = "LeftAnalogY : " + Input.GetAxis("LeftAnalogY1").ToString();
        joy1.txtRightAnalogX.text = "RightAnalogX : " + Input.GetAxis("RightAnalogX1").ToString();
        joy1.txtRightAnalogY.text = "RightAnalogY : " + Input.GetAxis("RightAnalogY1").ToString();
        joy1.txtA.text = "A : " + Input.GetButton("A1").ToString();
        joy1.txtB.text = "B : " + Input.GetButton("B1").ToString();
        joy1.txtX.text = "X : " + Input.GetButton("X1").ToString();
        joy1.txtY.text = "Y : " + Input.GetButton("Y1").ToString();
        joy1.txtDPadX.text = "DPadX : " + Input.GetAxis("DPadX1").ToString();
        joy1.txtDPadY.text = "DPadY : " + Input.GetAxis("DPadY1").ToString();
        joy1.txtLeftAnalogPress.text = "LeftAnalogPress : " + Input.GetAxis("LeftAnalogPress1");
        joy1.txtRightAnalogPress.text = "RightAnalogPress : " + Input.GetAxis("RightAnalogPress1");
    }
    private void ReadingJoystick2()
    {
        //LT is the positive values of the 3rd axis (Left Trigger)
        float LT = Input.GetAxis("LT2");
        LT = (LT > 0) ? LT : 0;

        //RT is the negative values of the 3rd axis (RightTrigger)
        float RT = Input.GetAxis("RT2");
        RT = (RT < 0) ? RT : 0;

        //18 inputs from joystick
        joy2.txtLT.text = "LT : " + LT.ToString();
        joy2.txtLB.text = "LB : " + Input.GetButton("LB2").ToString();
        joy2.txtRT.text = "RT : " + RT.ToString();
        joy2.txtRB.text = "RB : " + Input.GetButton("RB2").ToString();
        joy2.txtBack.text = "Back : " + Input.GetButton("Back2").ToString();
        joy2.txtStart.text = "Start : " + Input.GetButton("Start2").ToString();
        joy2.txtLeftAnalogX.text = "LeftAnalogX : " + Input.GetAxis("LeftAnalogX2").ToString();
        joy2.txtLeftAnalogY.text = "LeftAnalogY : " + Input.GetAxis("LeftAnalogY2").ToString();
        joy2.txtRightAnalogX.text = "RightAnalogX : " + Input.GetAxis("RightAnalogX2").ToString();
        joy2.txtRightAnalogY.text = "RightAnalogY : " + Input.GetAxis("RightAnalogY2").ToString();
        joy2.txtA.text = "A : " + Input.GetButton("A2").ToString();
        joy2.txtB.text = "B : " + Input.GetButton("B2").ToString();
        joy2.txtX.text = "X : " + Input.GetButton("X2").ToString();
        joy2.txtY.text = "Y : " + Input.GetButton("Y2").ToString();
        joy2.txtDPadX.text = "DPadX : " + Input.GetAxis("DPadX2").ToString();
        joy2.txtDPadY.text = "DPadY : " + Input.GetAxis("DPadY2").ToString();
        joy2.txtLeftAnalogPress.text = "LeftAnalogPress : " + Input.GetAxis("LeftAnalogPress2");
        joy2.txtRightAnalogPress.text = "RightAnalogPress : " + Input.GetAxis("RightAnalogPress2");
    }
}