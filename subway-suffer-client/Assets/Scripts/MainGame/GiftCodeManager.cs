using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiftCodeManager : MonoBehaviour
{
    public TMP_InputField codeInputField;
    public Button submitButton;

    private int valueGiftCodeCoin = 100000;
    private int valueGiftCodeKey = 100;

    void Start()
    {
        Button btn = submitButton.GetComponent<Button>();

        btn.onClick.AddListener(OnSubmitButtonClicked);
    }

    public void OnSubmitButtonClicked()
    {
        Debug.Log("Submit button clicked!");
        string enteredCode = codeInputField.text;

        ProcessGiftCode(enteredCode);
    }


    void ProcessGiftCode(string code)
    {
        if (code == "GIFT123")
        {
            Debug.Log("Gift code is valid!");
            AwardCoin();
            AwardKey();
        }
        else
        {
            Debug.Log("Invalid gift code!");
        }
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
