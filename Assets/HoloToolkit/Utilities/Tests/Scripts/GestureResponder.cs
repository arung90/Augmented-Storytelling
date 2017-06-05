using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class GestureResponder : MonoBehaviour, IInputClickHandler
{
    private const string Diving = "Diving";
    private const string ImagineRIT = "ImagineRIT";
    private const string Moana = "Moana";
    private const string PokeBall = "PokeBall";
    private const string Pokeball2 = "Pokeball2";
    private const string RIT = "RIT";
    private const string Rainbow = "Rainbow";
    private const string Snowman = "Snowman";
    private const string Friends = "Friends";
    private const string Pizza = "Pizza";
    private const string Earth = "Earth";
    private const string IPhone = "IPhone";
    private const string Sun = "Sun";


    private void Start()
    {
        InputManager.Instance.PushFallbackInputHandler(gameObject);
    }

    public void OnInputClicked(InputEventData eventData)
    {
        System.Diagnostics.Debug.WriteLine("OBJECT TYPE: " + this.gameObject.name); // this.gameObject.name = //Cube  this.gameObject.GetType() = //UnityEngine.GameObject

        Renderer r = this.GetComponent<Renderer>();
        System.Diagnostics.Debug.WriteLine("RENDERER: " + r.ToString());

        switch (this.gameObject.name)
        {
            case Diving:
                MovieTexture divingMovie = (MovieTexture)r.material.mainTexture;
                AudioSource divingAudio = this.GetComponent<AudioSource>();
                divingAudio.clip = divingMovie.audioClip;
                divingMovie.loop = true;
                divingAudio.loop = true;
                if (divingMovie.isPlaying)
                {
                    divingMovie.Pause();
                    divingAudio.Pause();
                }
                else
                {
                    divingMovie.Play();
                    divingAudio.Play();
                }
                break;

            case ImagineRIT:
                MovieTexture imagineRITMovie = (MovieTexture)r.material.mainTexture;
                AudioSource imagineRITAudio = this.GetComponent<AudioSource>();
                imagineRITAudio.clip = imagineRITMovie.audioClip;
                imagineRITMovie.loop = true;
                imagineRITAudio.loop = true;
                if (imagineRITMovie.isPlaying)
                {
                    imagineRITMovie.Pause();
                    imagineRITAudio.Pause();
                }
                else
                {
                    imagineRITMovie.Play();
                    imagineRITAudio.Play();
                }
                break;

            case Moana:
                AudioSource moanaAudio = this.GetComponent<AudioSource>();
                //moanaAudio.clip = moanaAudio[0];
                moanaAudio.loop = true;
                if (moanaAudio.isPlaying)
                {
                    moanaAudio.Pause();
                }
                else
                {
                    moanaAudio.Play();
                }
                break;

            case Friends:
                AudioSource friendsAudio = this.GetComponent<AudioSource>();
                //moanaAudio.clip = moanaAudio[0];
                friendsAudio.loop = true;
                if (friendsAudio.isPlaying)
                {
                    friendsAudio.Pause();
                }

                else
                {
                    friendsAudio.Play();
                }
                break;

            case PokeBall:
                break;

            case Pokeball2:
                break;

            case RIT:
                break;

            case Rainbow:
                break;

            case Snowman:
                break;

            case Pizza:
                break;

            case Earth:
                break;

            case IPhone:
                MovieTexture iPhoneMovie = (MovieTexture)r.material.mainTexture;
                AudioSource iPhoneAudio = this.GetComponent<AudioSource>();
                iPhoneAudio.clip = iPhoneMovie.audioClip;
                iPhoneMovie.loop = true;
                iPhoneAudio.loop = true;
                if (iPhoneMovie.isPlaying)
                {
                    iPhoneMovie.Pause();
                    iPhoneAudio.Pause();
                }
                else
                {
                    iPhoneMovie.Play();
                    iPhoneAudio.Play();
                }
                break;

            case Sun:
                break;

            default:
                break;
        }

        /*
        if (this.gameObject.name.Equals("Diving"))
        {
            MovieTexture movie = (MovieTexture)r.material.mainTexture;
            System.Diagnostics.Debug.WriteLine("MOVIE: " + movie.ToString());
            AudioSource audio = this.GetComponent<AudioSource>();
            System.Diagnostics.Debug.WriteLine("AUDIO: " + audio.ToString());
            audio.clip = movie.audioClip;

            if (movie.isPlaying)
            {
                movie.Pause();
                audio.Pause();
            }
            else
            {
                movie.Play();
                audio.Play();
            }

            movie.loop = true;
            audio.loop = true;
        }
        else
        {
            r.material.color = Color.blue;
            this.transform.Rotate(0, 1, 0);
        }
        */

        //PlaneTargetGroupPicker.Instance.PickNewTarget();
    }
}
