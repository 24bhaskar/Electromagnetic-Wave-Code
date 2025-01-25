using UnityEngine;
using UnityEngine.UI;
public class AmplitudePeriodScript : MonoBehaviour
{

    public Slider amplitudeSlider;
    public Slider periodSlider;

    private float amplitudeVal;
    private float periodVal;

    // Update is called once per frame
    void Update()
    {
        amplitudeVal = amplitudeSlider.value * 10f;
        Vector3 amplitude = new Vector3(transform.localScale.x, amplitudeVal, transform.localScale.z);
        this.transform.localScale = amplitude;

        periodVal = periodSlider.value * 10f;
        Vector3 period = new Vector3(periodVal, transform.localScale.y, transform.localScale.z);
        this.transform.localScale = period;
    }
}
