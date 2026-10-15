using UnityEngine;
using TMPro;

public class TimerText : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverText;
    [SerializeField] private Player _player;
    [SerializeField] private float _maxGameTime = 30.0f;
    [SerializeField] private TMP_Text _timerDisplay;
    [SerializeField] private Timer _gameTimer;

    // STEP 8 -----------------------------------------------------------------
    // This method runs ONCE, when the GAME BEGINS. It is called by Unity.
    // Uncomment this method and fill in the method name.

    private void Start() {
        _gameTimer.StopTime(false);
        _gameTimer.BeginTimer(_maxGameTime);
    }

    // STEP 8 -----------------------------------------------------------------

    // ------------------------------------------------------------------------
    private void Update()
    {
        // STEP 9 -------------------------------------------------------------
        // Inside this Update method, we're going to CHECK IF OUR TIMER RAN OUT.
        // IF it's done, CALL the GameOver method.
        // If you need a hint, check how the KickWeapon class did this.
        // But remember the timer object in this class is _gameTimer.
        //
        // Write your if statement below.

        // STEP 9 -------------------------------------------------------------

        _timerDisplay.text = _gameTimer.GetTimeLeft().ToString();

        if (_gameTimer.IsFinished()) {
            _timerDisplay.text = "0.000";   // Fixes the issue of displaying negative time
            _gameTimer.StopTime(true);      // Prevents the timer from continuing after a game over
            GameOver();
        }

    }
    
    // ------------------------------------------------------------------------
    private void GameOver ()
    {
        _player.SetGameOver();
        _gameOverText.SetActive(true);
    }
}