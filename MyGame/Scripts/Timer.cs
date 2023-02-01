using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Time_text;
    public int scorenumber;
    string score_str;
    [SerializeField]
    TextMeshProUGUI Score;
    [SerializeField]
    float Time_int;
    float Time_int_round;
    string time_time;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {
        Time_int -= Time.deltaTime;
        Time_int_round = Mathf.Round(Time_int);
        time_time = Time_int_round.ToString();
        Time_text.text = time_time;

        score_str = scorenumber.ToString();
        Score.text = score_str;
        if (Time_int < 0)
        {
            Time_int = 0;
        }
    }
}
