using com.Neogoma.Stardust.API;
using com.Neogoma.Stardust.API.Mapping;
using com.Neogoma.Stardust.Datamodel;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Neogoma.Stardust.Demo.Mapper
{
    /// <summary>
    /// Class used to export data to the pointcloud API
    /// </summary>
    public class Exporter: MonoBehaviour
    {
        /// <summary>
        /// Text element to show how many pictures were taken
        /// </summary>
        public Text pictureTakenText;

        /// <summary>
        /// Text element to show how many pictures were sucessfully uploaded
        /// </summary>
        public Text pictureSentText;

        /// <summary>
        /// Data limit reached text
        /// </summary>
        public Text dataLimitReached;

        /// <summary>
        /// Session controller to manage the different sessions
        /// </summary>
        private SessionController sessionController;

        /// <summary>
        /// Event triggered when session is initialized
        /// </summary>
        public UnityEvent sessionInitialized = new UnityEvent();

        /// <summary>
        /// Object manager for setting up the session
        /// </summary>
        public ObjectManager objectManager;

        /// <summary>
        /// Showing the session ID
        /// </summary>
        public Text idSession;

        private MapDataUploader dataUploader;

        public void Awake()
        {
            sessionController = SessionController.Instance;
            sessionController.onSessionCreationSucess.AddListener(SessionCreated);
            CreateSession();

            dataUploader = MapDataUploader.Instance;
            
            dataUploader.onDataCapturedSucessfully.AddListener(OnDataCaptured);
            dataUploader.onDataSentSucessfully.AddListener(OnDataSentSuccess);
            dataUploader.onDatalimitReached.AddListener(OnDataLimitReached);
        }

        private void CreateSession()
        {
            sessionController.CreateMappingSession();
        }

        private void SessionCreated(Session session)
        {
            idSession.text = session.name;
            objectManager.SetupSession(session);
            
            sessionInitialized.Invoke();
            

        }

    

        private void OnDataCaptured(int datacount)
        {
            pictureTakenText.text = datacount.ToString();
        }

        private void OnDataSentSuccess(int uploadCount)
        {
            pictureSentText.text = uploadCount.ToString();
        }

        private void OnDataLimitReached()
        {
            dataLimitReached.gameObject.SetActive(true);
            
        }
    }
}