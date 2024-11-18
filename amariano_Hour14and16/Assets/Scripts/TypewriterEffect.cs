using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TypewriterEffect : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string fullText = "He seems busy... We should go back...";
    public float typingSpeed = 0.05f;
    public GameObject button;
    public Animator panelAnimator;

    private void Start()
    {
        textComponent.text = "";
        button.SetActive(false);
        
        panelAnimator.Play("TextBoxIntro");
        StartCoroutine(StartTypingAfterDelay(0.5f));
    }

    private IEnumerator StartTypingAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        StartCoroutine(TypeText(fullText));
    }

    private IEnumerator TypeText(string message)
    {
        textComponent.text = "";
        foreach (char letter in message.ToCharArray())
        {
            textComponent.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        button.SetActive(true);
    }
}