using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public RectTransform MenuSlider;
    private Vector2 ButtonVelocity = Vector2.zero;
    private float SmoothTime = 0.2f;
    int option;

    public Vector2 Settings = new Vector2(732f, 4.5f);
    public Vector2 MainMenu = new Vector2(-48f, 4.5f);
    public Vector2 ExitMenu = new Vector2(-796f, 4.5f);






    // Start is called before the first frame update



    void Start()
    { 
        MenuSlider = GetComponent<RectTransform>();

    }


    void Update() {

        switch (option) {

            case 1:
       MenuSlider.localPosition = Vector2.SmoothDamp(MenuSlider.localPosition, Settings, ref ButtonVelocity, SmoothTime);
                break;
            case 2:
                MenuSlider.localPosition = Vector2.SmoothDamp(MenuSlider.localPosition, MainMenu, ref ButtonVelocity, SmoothTime);
                break;
            case 3:
                MenuSlider.localPosition = Vector2.SmoothDamp(MenuSlider.localPosition, ExitMenu, ref ButtonVelocity, SmoothTime);
                break;
            default:
                break;

        }

    }


    public void Play() {
  
        SceneManager.LoadScene("Game",LoadSceneMode.Single);

    }

    public void Quit()
    {
        Application.Quit();

    }

    public void MMenu() {
        
        option = 2;
        Update();
    }

    public void EMenu() {
        option = 3;
        Update();
    }

    public void SMenu() {
      option =1;
        Update();
    }







}
