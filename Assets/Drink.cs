using UnityEngine;
using UnityEngine.UI;

public class Drink : MonoBehaviour
{
    public InputField drinks;
    
    
    public Text DText;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (drinks.text.Length >1)
        DText.text= (drinks.text == "紅水") ? "恢復血量" : (drinks.text == "藍水") ? "恢復魔力" : "不要亂喝哦";
    }
}
