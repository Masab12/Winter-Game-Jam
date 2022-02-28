using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EdgeWay.Unity.EZSplashScreen;

namespace EdgeWay.Unity
{
    public class CallFromScript : MonoBehaviour
    {
        private void Awake()
        {
 
        }
        // Start is called before the first frame update
        void Start()
        {
            // start the splash screen from script
            EZSplashScreens.StartSplashScreens();
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

