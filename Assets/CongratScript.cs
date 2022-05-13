using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    private List<string> TextToDisplay = new List<string>();

    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        //TimeToNextText = 0.0f;
        CurrentText = 0;

        RotatingSpeed = 1.0f;

        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");

        Text.text = TextToDisplay[0];

        SparksParticles.Play();

        StartCoroutine(ChangeText());
    }

    // Update is called once per frame
    void Update()
    {
        //TimeToNextText += Time.deltaTime;

        //if (TimeToNextText > 1.5f)
        //{
        //    TimeToNextText = 0.0f;

        //    CurrentText++;
        //    if (CurrentText >= TextToDisplay.Count)
        //    {
        //        CurrentText = 0;


        //        Text.text = TextToDisplay[CurrentText];
        //    }
        //}



        //transform.Rotate(Vector3.up * RotatingSpeed);
        transform.SetPositionAndRotation(Vector3.up * RotatingSpeed, transform.rotation);
     }


    IEnumerator ChangeText()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.5f);

            switch (CurrentText)
            {
                case 0:
                    CurrentText = 1;
                    Text.text = TextToDisplay[CurrentText];
                    break;
                case 1:
                    CurrentText = 0;
                    Text.text = TextToDisplay[CurrentText];
                    break;
            }
        }
    }
}