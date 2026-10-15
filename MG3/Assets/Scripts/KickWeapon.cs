using UnityEngine;

public class KickWeapon : MonoBehaviour
{
    [SerializeField] private float _lifetimeSeconds;
    [SerializeField] private Timer _lifeTimer;

    private bool _kickComplete = true;  // Prevents kick spam. Space input is checked every frame and the timer will always reset. A debounce was needed.

    // ------------------------------------------------------------------------
    public void ActivateKick()
    {
        gameObject.SetActive(true);

        // STEP 6 -------------------------------------------------------------
        // In addition to accessing member variables from an object with '.',
        //      we can also call methods.
        // Uncomment the below line and pass _lifetimeSeconds as an ARGUMENT
        //      to the method in order to start our timer with the number
        //      of seconds that _lifetimeSeconds is set to.

        _kickComplete = false;
        _lifeTimer.BeginTimer(_lifetimeSeconds);

        // STEP 6 -------------------------------------------------------------
    }

    public bool KickCompleted() // Checks whether or not the kick is completed
    {
        return _kickComplete;
    }

    // STEP 7 -----------------------------------------------------------------
    // Finally, we need to check EVERY FRAME for when the timer has run up.
    //
    // Uncomment the below method and replace the ???s with the method name.
    // This is a built-in method from Unity that runs EVERY FRAME.
    //


    private void Update() {
       if (_lifeTimer.IsFinished()) {
            gameObject.SetActive(false);
            _kickComplete = true;
       }
    }



    // In the body of this method, we want to check if the timer has run out,
    //      and disable the KickWeapon when it's done.
    // Simply uncomment the lines once you've written the method.
    // STEP 7 -----------------------------------------------------------------
}