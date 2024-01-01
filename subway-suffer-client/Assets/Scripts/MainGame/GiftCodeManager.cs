using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using System.IO;

public class GiftCodeManager : MonoBehaviour
{
    public TMP_InputField codeInputField;
    public Button submitButton;
    public TextMeshProUGUI feedbackText;

    private int valueGiftCodeCoin = 100000;
    private int valueGiftCodeKey = 100;
    private List<string> giftCodes = new List<string>();
    private HashSet<string> usedGiftCodes = new HashSet<string>();
    private string filePath = "Assets/Resources/giftcodes.txt";

    void Start()
    {
        LoadGiftCodes();
        Button btn = submitButton.GetComponent<Button>();
        btn.onClick.AddListener(OnSubmitButtonClicked);
    }

    void LoadGiftCodes()
    {
        string[] loadedCodes;
        try
        {
            loadedCodes = File.ReadAllLines(filePath);
        }
        catch (IOException e)
        {
            Debug.LogError("Error reading file: " + e.Message);
            return;
        }

        if (loadedCodes != null)
        {
            giftCodes.AddRange(loadedCodes);
        }
    }

    public void OnSubmitButtonClicked()
    {
        string enteredCode = codeInputField.text;

        if (usedGiftCodes.Contains(enteredCode))
        {
            feedbackText.text = "Gift code has already been used!";
        }
        else
        {
            if (ProcessGiftCode(enteredCode))
            {
                usedGiftCodes.Add(enteredCode);
                feedbackText.text = "Gift code is valid! Congratulations!";

                Invoke(nameof(ClearFeedbackText), 3f);
            }
            else
            {
                feedbackText.text = "Invalid gift code! Please try again.";
                
                Invoke(nameof(ClearFeedbackText), 3f);
            }
        }
    }

    bool ProcessGiftCode(string code)
    {
        if (giftCodes.Contains(code))
        {
            AwardCoin();
            AwardKey();
            return true;
        }
        return false;
    }

    void AwardCoin()
    {
        Modules.GiftCodeCoin(valueGiftCodeCoin);
    }

    void AwardKey()
    {
        Modules.GiftCodeKey(valueGiftCodeKey);
    }

    
    void ClearFeedbackText()
    {
        feedbackText.text = "";
    }
}
