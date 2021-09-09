using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreen : MonoBehaviour
{
    public void GoToAboutUs() //Nama untuk About Us
    {
        SceneManager.LoadScene("AboutUs"); //Menuju Scene About Us
    }
    public void ExitApplication()// Nama untuk Exit Application
    {
        Application.Quit(); // Untuk Keluar Dari Aplikasi
    }
    public void GoToHowToUse() // Nama untuk How To Use
    {
        SceneManager.LoadScene("HowToUse"); //Menuju Scene How To Use
    }
    public void GoToTrailer() //Nama untuk trailer
    {
        SceneManager.LoadScene("TRAILER"); //Menuju Scene Trailer
    }
    public void GoToSchedule() //Nama untuk schedule
    {
        SceneManager.LoadScene("Schedule"); //Menuju Scene Schedule
    }
}
