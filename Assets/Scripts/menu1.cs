using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu1 : MonoBehaviour
{
  public void entrar(){
        SceneManager.LoadScene("SampleScene");
    }
    public void salir(){
        Application.Quit();

    }
}
