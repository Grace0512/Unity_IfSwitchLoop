using UnityEngine;
using UnityEngine.UI;

public class HPSlider : MonoBehaviour
{
    public Slider HPslider;
    public Text HPText;
   private float HP;

    public float HP1 { get => HP; set => HP = value; }

    void Start()
    {
        HPslider.minValue = 0;
        HPslider.maxValue = 100;
        HP1 = HPslider.value;
    }

    // Update is called once per frame
    void Update()
    {
        // 判斷目前滑桿血量
        HP1 = HPslider.value;
        HPControl(HP1);
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
