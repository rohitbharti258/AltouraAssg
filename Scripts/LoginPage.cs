using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginPage : MonoBehaviour
{
    public InputField usernameInputField;
    public InputField passwordInputField;
    // public Text errorText="";

    private string correctUsername = "user";
    private string correctPassword = "password";

    public void onClick()
    {
        string username = usernameInputField.text;
        string password = passwordInputField.text;

        if(username == correctUsername && password == correctPassword)
        {
            SceneManager.LoadScene("Home");
        }
        else
        {
            // errorText.Text = "Incorrect username or password! Try again";
            Debug.Log("Incorrect username or password!");

        }
    }
    
}
