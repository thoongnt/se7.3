using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GiftCodeManager : MonoBehaviour
{
    public TMP_InputField codeInputField;
    public Button submitButton;

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
            AwardGold();
            UnlockFeature();
        }
        else
        {
            Debug.Log("Invalid gift code!");
        }
    }

    void AwardGold()
    {
        Debug.Log("Received gold!");
    }

    void UnlockFeature()
    {
        Debug.Log("Unlocked feature!");
    }
}
