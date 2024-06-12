using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public PlayerCntrl PlayerCntrlReff;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCntrlReff = GameObject.Find("Player").GetComponent<PlayerCntrl>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = PlayerCntrlReff.currentScore.ToString() + " M";
    }
}
