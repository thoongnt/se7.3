using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiftCodeManager : MonoBehaviour
{
    public TMP_InputField codeInputField;
    public Button submitButton;
    public TextMeshProUGUI feedbackText;

    private int valueGiftCodeCoin = 100000;
    private int valueGiftCodeKey = 100;

    void Start()
    {
        Button btn = submitButton.GetComponent<Button>();
        btn.onClick.AddListener(OnSubmitButtonClicked);
    }

    public void OnSubmitButtonClicked()
    {
        string enteredCode = codeInputField.text;

        if (ProcessGiftCode(enteredCode))
        {
            feedbackText.text = "Gift code is valid! Congratulations!";
        }
        else
        {
            feedbackText.text = "Invalid gift code! Please try again.";
        }
    }

    bool ProcessGiftCode(string code)
    {
        if (code == "GIFT123")
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
}
