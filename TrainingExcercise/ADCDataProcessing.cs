using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace TrainingExcercise
{
    public class DataSimulator
    {
        private BlockingCollection<(int Value, DateTime Timestamp)> dataCollection = new BlockingCollection<(int, DateTime)>();

        // Cancellation token source to cancel tasks gracefully
        private CancellationTokenSource cts = new CancellationTokenSource();
        private int subsampleRate = 5; // Skip every 5th sample (for subsampling during processing)
        private int maxDataCount = 30; // Simulate collection of 30 data points
        public void Start()
        {
            // Start the data collection and processing tasks
            Task.Run(() => CollectData(cts.Token));  // Data collection task
            Task.Run(() => ProcessData(cts.Token));  // Data processing task
        }

        // Method to simulate ADC data collection
        private void CollectData(CancellationToken token)
        {
            Random random = new Random();
            int counter = 0;

            while (!token.IsCancellationRequested && counter < maxDataCount)
            {
                // Simulate reading ADC data (a random integer between 0 and 1023)
                int adcValue = random.Next(0, 1024);

                // Timestamp for each collected sample
                DateTime timestamp = DateTime.UtcNow;

                // Add the data and timestamp to the collection
                dataCollection.Add((adcValue, timestamp));
                Console.WriteLine($"Data Collected at {timestamp:yyyy-MM-dd HH:mm:ss}: {adcValue}");

                // Simulate a delay between ADC readings (500ms)
                Thread.Sleep(500);
                counter++;
            }
            Console.WriteLine("Data collection completed.");
            dataCollection.CompleteAdding(); // Mark the collection as complete
        }

        // Method to asynchronously process the ADC data (with subsampling)
        private async Task ProcessData(CancellationToken token)
        {
            await Task.Yield(); // Ensures we are in async mode
            int count = 0;

            // Process data (subsampling during processing)
            while (!token.IsCancellationRequested)
            {
                try
                {
                    // Take one item from the collection
                    var data = dataCollection.Take(token);
                    // Apply subsampling logic (process every nth sample)
                    if (count % subsampleRate == 0)
                    {
                        Console.WriteLine($"Processing Data at {data.Timestamp:yyyy-MM-dd HH:mm:ss}: {data.Value} (Subsampled)");
                        await ProcessSingleDataAsync(data.Value);
                    }

                    count++;
                    if (count >= maxDataCount) break; // Stop after processing all collected data
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Processing was canceled.");
                    break;
                }
            }
            Console.WriteLine("Data processing completed.");
        }

        // Simulate asynchronous processing (e.g., data transformations)
        private Task ProcessSingleDataAsync(int data)
        {
            return Task.Run(() =>
            {
                // Simulate processing (e.g., apply filter, calculation, or transformation)
                Thread.Sleep(300); // Simulate some delay in processing
                Console.WriteLine($"Processed data: {data * 2}"); // Example processing (doubling the value)
            });
        }

        // Stop the data collection and processing gracefully
        public void Stop()
        {
            cts.Cancel();  // Cancel the tasks
        }
    }

    internal class ADCDataProcessing
    {
        public void Run()
        {
            var adcSimulator = new DataSimulator();
            adcSimulator.Start();

            // Wait for user input to stop the simulation
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

            // Stop the simulation
            adcSimulator.Stop();
            Console.WriteLine("Simulation stopped.");
        }
    }
}
