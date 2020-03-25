using UnityEngine;
using UnityEngine.UI;

namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by the player
        public Bike m_PlayerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndroidBike;

        // Bike controlled by an alien (AI)
        public Bike m_AlienBike;

        // Bike controlled by a golem (AI)
        public Bike m_GolemBike;

        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();
            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            //m_PlayerBike.StartEngine();
            
            // Set up a bike with an android AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();
            m_AndroidBike.SetEngine(nitroEngine);
            m_AndroidBike.SetDriver(androidDriver);
            //m_AndroidBike.StartEngine();

            // Set up a bike with an alien AI driver and a solar engine
            IEngine solarEngine = new SolarEngine();
            IDriver alienDriver = new AlienDriver();
            m_AlienBike.SetEngine(solarEngine);
            m_AlienBike.SetDriver(alienDriver);
            //m_AlienBike.StartEngine();

            // Set up a bike with a golem driver and an anchient engine
            IEngine anchientEngine = new AnchientEngine();
            IDriver golemDriver = new GolemDriver();
            m_GolemBike.SetEngine(anchientEngine);
            m_GolemBike.SetDriver(golemDriver);
            // m_GolemBike.StartEngine();
        }
        void Update()
        {
            // Steering Checks
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }

            // G to start golem bike
            if (Input.GetKeyDown(KeyCode.G))
            {
                m_GolemBike.StartEngine();
            }

            // N to start Android Bike
            if (Input.GetKeyDown(KeyCode.N))
            {
                m_AndroidBike.StartEngine();
            }

            // L to start Alien Bike
            if (Input.GetKeyDown(KeyCode.L))
            {
                m_AlienBike.StartEngine();
            }

            // P to start Player Bike
            if (Input.GetKeyDown(KeyCode.P))
            {
                m_PlayerBike.StartEngine();
            }
        }


        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
           
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
        }
    }
}
