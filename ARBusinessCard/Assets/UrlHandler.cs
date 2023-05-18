using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UrlHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ig()
    {
        Application.OpenURL("https://www.instagram.com/tati_792/");
    }

    public void github()
    {
        Application.OpenURL("https://github.com/Titania792");
    }

    public void Linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/tatianafernandez792/");
    }

    public void gmail()
    {
        Application.OpenURL("mailto:tatifernandez34@gmail.com");
    }
}
