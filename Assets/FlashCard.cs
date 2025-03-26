using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;


[Serializable]
class MemoryCard
{
    public string answer;
    public string question;
}

public class FlashCard : MonoBehaviour, IPointerClickHandler
{
    private int currentCardIndex;
    [SerializeField] private List<MemoryCard> memoryCards;
    bool showAnswer;

    [SerializeField] TextMeshProUGUI text;

   
    

    public void OnPointerClick(PointerEventData eventData)
    {
        print("hej");
        //byta texten på kortet
        showAnswer = !showAnswer;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        //UpdateText();
    }

    // Update is called once per frame
    void Update()
    {
        if (showAnswer == true)
        {
            text.text = memoryCards[currentCardIndex].answer;
        }
        else {
            text.text = memoryCards[currentCardIndex].question;
        }
        
    }

    private void NextCard()
    {
        currentCardIndex = (currentCardIndex + 1) % memoryCards.Count;
        DisplayQuestion();
    }

    private void DisplayQuestion()
    {
        throw new NotImplementedException();
    }
}
