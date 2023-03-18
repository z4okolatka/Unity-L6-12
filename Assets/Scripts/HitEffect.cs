using TMPro;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    public void Init(int value)
    {
        _text.text = "+" + value.ToString();
        Debug.Log(_text.text);
        Destroy(gameObject, 2f);
    }

}
