using UnityEngine;
using UnityEngine.UI;

public class HPSlider : MonoBehaviour
{
    public Slider HPslider;
    public Text HPText;
    public float HP;
   
    void Start()
    {
        HPslider.minValue = 0;
        HPslider.maxValue = 100;
        HP = HPslider.value;
    }

    // Update is called once per frame
    void Update()
    {
        // 判斷目前滑桿血量
        HP = HPslider.value;
        HPControl(HP);
    }

    void HPControl(float HP)
    {
       
        if(HP >= 70)
        {
            HPText.text = "安全";
        }else if(HP >= 30)
        {
            HPText.text = "警告";
        }else
        {
            HPText.text = "危險";
        }

    }
}
