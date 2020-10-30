using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Language
{
    English,
    Chinese,
    Malay,
    Tamil
}

public class LanguageSelect : MonoBehaviour
{
    public static Language language;

    public void selectEnglish() {
        language = Language.English;
    }
    public void selectChinese() {
        language = Language.Chinese;
    }
    public void selectMalay() {
        language = Language.Malay;
    }
    public void selectTamil() {
        language = Language.Tamil;
    }
}

public class StringsDictionary : MonoBehaviour
{
    public static string buttonString_Back {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "Back";
                case Language.Chinese:
                return "返回";
                case Language.Malay:
                return "Kembali";
                case Language.Tamil:
                return "முன்னைய";
                default: 
                return "Back";
            }
        }
    } 
    public static string buttonString_End {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "End";
                case Language.Chinese:
                return "结束";
                case Language.Malay:
                return "Tamat";
                case Language.Tamil:
                return "முடிவு";
                default:
                return "End";
            }
        }
    } 
    public static string buttonString_Confirm {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "Confirm";
                case Language.Chinese:
                return "确认";
                case Language.Malay:
                return "Mengesahkan";
                case Language.Tamil:
                return "சரி";
                default:
                return "Confirm";
            }
        }
    } 
    public static string buttonString_SeeResultsAgain {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "Click here to\nsee results again";
                case Language.Chinese:
                return "点击这里\n重新观看结果";
                case Language.Malay:
                return "Klik di sini untuk\nmelihat hasilnya sekali lagi";
                case Language.Tamil:
                return "கெலிப்புப்புள்ளிகளை மீண்டும்\nகாண இங்கு அழுத்துங்கள்";
                default:
                return "Click here to\nsee results again";
            }
        }
    } 
    public static string testSceneString_01 {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "Enter letter...";
                case Language.Chinese:
                return "请输入字母...";
                case Language.Malay:
                return "Masukkan surat";
                case Language.Tamil:
                return "கடிதத்தை உள்ளிடவும்...";
                default:
                return "Enter letter...";
            }
        }
    } 
    public static string endSceneString_01 {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "Your visual acuity score is:";
                case Language.Chinese:
                return "您的视力指标是：";
                case Language.Malay:
                return "Keputusan ujian ketajaman penglihatan anda adalah:";
                case Language.Tamil:
                return "உங்கள் பார்வைக் கூர்மை கெலிப்புப்புள்ளிகள்-";
                default:
                return "Your visual acuity score is:";
            }
        }
    } 
    public static string endSceneString_02 {
        get {
            switch (LanguageSelect.language)
            {
                case Language.English:
                return "You have come to the end of the visual acuity test\nClick anywhere to return to the main menu";
                case Language.Chinese:
                return "您的视力测试已结束\n请点击任意地方回到主页";
                case Language.Malay:
                return "Anda telah sampai ke ahir ujian ketajaman penglihatan\nUntuk kembali kepada menu utama, sila klik di mana sahaja";
                case Language.Tamil:
                return "பார்வைக் கூர்மைப் பரி சோதனையின் இறுதிக்கு வந்துவிட்டீர\nமுதற்பக்கத்திற்குச் செல்ல எங்காவது அழுத்துங்கள்";
                default:
                return "You have come to the end of the visual acuity test\nClick anywhere to return to the main menu";
            }
        }
    } 
}
