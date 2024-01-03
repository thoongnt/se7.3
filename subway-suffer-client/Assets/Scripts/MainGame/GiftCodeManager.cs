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

    private Dictionary<string, Reward> giftCodes = new Dictionary<string, Reward>();
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

        foreach (string code in loadedCodes)
        {
            string[] codeData = code.Split(':');
            if (codeData.Length == 3)
            {
                string codeValue = codeData[0].Trim();
                int coinReward = int.Parse(codeData[1].Trim());
                int keyReward = int.Parse(codeData[2].Trim());
                giftCodes.Add(codeValue, new Reward(coinReward, keyReward));
            }
        }
    }

    public void OnSubmitButtonClicked()
    {
        string enteredCode = codeInputField.text;

        if (usedGiftCodes.Contains(enteredCode))
        {
            ShowFeedback("Gift code has already been used!");
        }
        else
        {
            if (giftCodes.ContainsKey(enteredCode))
            {
                Reward reward = giftCodes[enteredCode];
                AwardGift(reward.CoinReward, reward.KeyReward);
                usedGiftCodes.Add(enteredCode);
                ShowFeedback("Gift code is valid! Congratulations!");
            }
            else
            {
                ShowFeedback("Invalid gift code! Please try again.");
            }
        }
    }

    void AwardGift(int coinReward, int keyReward)
    {
        Modules.GiftCodeCoin(coinReward);
        Modules.GiftCodeKey(keyReward);
    }

    void ShowFeedback(string message)
    {
        feedbackText.text = message;
        Invoke(nameof(ClearFeedbackText), 3f);
    }

    void ClearFeedbackText()
    {
        feedbackText.text = "";
    }
}

public class Reward
{
    public int CoinReward { get; }
    public int KeyReward { get; }

    public Reward(int coinReward, int keyReward)
    {
        CoinReward = coinReward;
        KeyReward = keyReward;
    }
}
