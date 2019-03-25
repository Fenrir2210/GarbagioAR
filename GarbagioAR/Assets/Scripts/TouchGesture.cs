using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchGesture : MonoBehaviour
{
    [System.Serializable]
    public class GestureSettings
    {
        public float minSwipeDist = 100;
        public float maxSwipeTime = 10;
    }
    private GestureSettings settings;
    private float swipeStartTime;
    private bool couldBeSwipe;
    private Vector2 startPos;
    private int stationaryForFrames;
    private TouchPhase lastPhase;
    public TouchGesture(GestureSettings gestureSettings)
    {
        settings = gestureSettings;
    }

    public IEnumerator CheckVerticalSwipes(System.Action swipeUp, System.Action swipeDown) //Coroutine we run in "start()" checking for swipes during run time
    {
        while(true) // Loop Loop Loop Loop
        {
            foreach(Touch touch in Input.touches) // For each touch in the touch array
            {

                switch(touch.phase)
                {
                    case TouchPhase.Began: //Finger is touching the screen, the gesture MAY become a swipe up or swipe down
                        couldBeSwipe = true;
                        startPos = touch.position; //Origin point of the gesture
                        swipeStartTime = Time.time; //Time the gesture starts at
                        stationaryForFrames = 0;
                        break;
                    case TouchPhase.Stationary: //If the finger doesnt move, there is no swipe
                        if (isStationary(6))
                            couldBeSwipe = false;
                        break;
                    case TouchPhase.Ended: //The finger has lifted, lets see if a swipe was made
                        if(isASwipe(touch))
                        {
                            couldBeSwipe = false; //<-- Otherwise this part would be called over and over again.
                            if (Mathf.Sign(touch.position.x - startPos.x) == 1f) //Swipe-direction, either 1 or -1.   
                                swipeUp(); //Up-swipe
                            else
                                swipeDown(); //Down-swipe
                        }
                        break;
                }
                lastPhase = touch.phase;
            }
            yield return null;
        }
    }

    //Helper Stuff\\
    private bool isASwipe(Touch touch) //returns bool if the touch input is a proper vertical swipe (satisfying minimum conditions of dist and time)
    {
        float swipeTime = Time.time - swipeStartTime; //Time the touch stayed on screen, from start to now
        float swipeDist = Mathf.Abs(touch.position.y - startPos.y); //Vertical swipe distance

        return couldBeSwipe && swipeTime < settings.maxSwipeTime && swipeDist > settings.minSwipeDist;
    }

    private bool isStationary(int framesStationaryFor)
    {
        if (lastPhase == TouchPhase.Stationary)
            stationaryForFrames++;
        else //reset to 1
            stationaryForFrames = 1;
        return stationaryForFrames > framesStationaryFor; //if the touch phase is stationary for more than the provided time, return true
    }

}
