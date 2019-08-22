using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace monkeyMath
{
    public class GetWrongAns : MonoBehaviour
    {
        void Update()
        {
            for (int i = 0; i < 20; i++)
		    {
			    GameObject.Find("Canvas/Background/SchoolBoard/Page 1/WA/"+(i+1).ToString()).GetComponent<Text>().text = PlayerPrefs.GetString("WA"+i.ToString());
		    }

            //Save wrong answers
            for (int i = 0; i < 9; i++)
		    {
			    GameObject.Find("Canvas/Background/SchoolBoard/Page 2/FailAddition/"+(i+1).ToString()).GetComponent<Text>().text = "+" + (i+1) + "     " +PlayerPrefs.GetInt("AdditionFailLevel"+(i+1).ToString()).ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 2/FailAddition/10").GetComponent<Text>().text = "+10"  + "   " +PlayerPrefs.GetInt("AdditionFailLevel10").ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 2/FailSubtraction/"+(i+1).ToString()).GetComponent<Text>().text = "-" + (i+1) + "     " +PlayerPrefs.GetInt("SubtractionFailLevel"+(i+1).ToString()).ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 2/FailSubtraction/10").GetComponent<Text>().text = "-10"  + "   " +PlayerPrefs.GetInt("SubtractionFail10").ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 3/FailMultiplication/"+(i+1).ToString()).GetComponent<Text>().text = "×" + (i+1) + "     " +PlayerPrefs.GetInt("MultiplicationFailLevel"+(i+1).ToString()).ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 3/FailMultiplication/10").GetComponent<Text>().text = "+10"  + "   " +PlayerPrefs.GetInt("MultiplicationFailLevel10").ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 3/FailDivision/"+(i+1).ToString()).GetComponent<Text>().text = "÷" + (i+1) + "     " +PlayerPrefs.GetInt("DivisionFailLevel"+(i+1).ToString()).ToString();
                GameObject.Find("Canvas/Background/SchoolBoard/Page 3/FailDivision/10").GetComponent<Text>().text = "-10"  + "   " +PlayerPrefs.GetInt("DivisionFail10").ToString();
            }
        }
    }
}

