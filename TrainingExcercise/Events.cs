using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{

        public class YouTubeChannel
    {
        // Step 1: Define the event using EventHandler delegate
        public event EventHandler VideoUploaded;

        // Method to upload a video, and trigger the event
        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"Video uploaded: {videoTitle}");

            // Step 3: Raise the event when a video is uploaded
            OnVideoUploaded();
        }

        // Step 2: Method to raise the event
        protected virtual void OnVideoUploaded()
        {
            // Check if there are any subscribers
            VideoUploaded?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Subscriber
    {
        // Event handler method
        public void OnVideoUploaded(object sender, EventArgs e)
        {
            Console.WriteLine("A new video has been uploaded! Sending notification to subscriber.");
        }
    }

    internal class Events
    {
        public void Run()
        {
            // Step 4: Create a new YouTube channel instance
            YouTubeChannel myChannel = new YouTubeChannel();

            // Step 5: Create a new subscriber instance
            Subscriber subscriber = new Subscriber();

            // Step 6: Subscribe to the VideoUploaded event
            myChannel.VideoUploaded += subscriber.OnVideoUploaded;

            // Step 7: Simulate uploading videos
            myChannel.UploadVideo("How to Learn C#");
            myChannel.UploadVideo("Understanding Events in C#");
        }
    }

}


