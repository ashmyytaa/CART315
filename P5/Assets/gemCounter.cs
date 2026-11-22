using UnityEngine;
using TMPro;

public class GemCounter : MonoBehaviour{
    public static GemCounter Instance;
    public TextMeshProUGUI counterText;
    private int gemsCollected = 0;

    void Awake(){
        Instance = this;
        UpdateCounter();
    }

    public void AddGem(){
        gemsCollected++;
        UpdateCounter();
    }

    void UpdateCounter(){
        if (counterText != null){
            counterText.text = "" + gemsCollected;
        }
    }
}