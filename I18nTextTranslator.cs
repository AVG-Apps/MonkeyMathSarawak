using UnityEngine;
using UnityEngine.UI;

public class I18nTextTranslator : MonoBehaviour
{
    public string TextId;

    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        var text = GetComponent<Text>();
        if (text != null)
            if (TextId == "ISOCode")
                text.text = I18n.GetLanguage();
            else
                text.text = I18n.Fields[TextId];
    }

    public void changeLanguage(string lang_code)
    {
        I18n.LoadLanguage(lang_code);
        Debug.Log("TT:" + lang_code);
    }
}