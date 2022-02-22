using UnityEngine;

public class CodeInput : MonoBehaviour
{
    [SerializeField] TextUI _text;
    public int Value { get; private set; }
    const int MaxValue = 9;

    void OnEnable() => SetAs(0);
    void UpdateText() => _text?.SetText(Value.ToString());

    void SetAs(int n)
    {
        Value = n;
        UpdateText();
    }

    public void Increase()
    {
        Value = (Value + 1) > MaxValue ? 0 : Value + 1; 
        UpdateText();
    }

    public void Decrease()
    {
        Value = (Value - 1) < 0 ? MaxValue : Value - 1; 
        UpdateText();
    }
}