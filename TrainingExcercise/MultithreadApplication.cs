using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
   public class ADCDataSimulator
    {
        // This collection will hold the simulated ADC data
        private BlockingCollection<int> dataCollection = new BlockingCollection<int>();

        // Cancellation token source to cancel tasks gracefully
        private CancellationTokenSource cts = new CancellationTokenSource();

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
            while (!token.IsCancellationRequested)
            {
                // Simulate reading ADC data (a random integer between 0 and 1023)
                int adcValue = random.Next(0, 1024);
                dataCollection.Add(adcValue);  // Add the data to the collection
                Console.WriteLine($"Data Collected: {adcValue}");

                // Simulate a delay between ADC readings
                Thread.Sleep(500); // Collect data every 500ms
                counter++;

                if (counter >= 20) break;  // Simulate collection of 20 data points
            }

            Console.WriteLine("Data collection stopped.");
            dataCollection.CompleteAdding(); // Mark the collection as complete
        }

        // Method to asynchronously process the ADC data
        private async Task ProcessData(CancellationToken token)
        {
            await Task.Yield(); // Ensures we are in async mode
            int count = 0;
            while (!token.IsCancellationRequested)
            {
                try
                {
                    // Simulate processing the data
                    int adcValue = dataCollection.Take(token); // Take one item from the collection
                    Console.WriteLine($"Processing Data: {adcValue}");

                    // Simulate processing (e.g., calculate the average, apply filters)
                    await ProcessSingleDataAsync(adcValue);

                    count++;
                    if (count >= 20) break; // Stop after processing 20 items
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Processing was canceled.");
                    break;
                }
            }
            Console.WriteLine("Data processing stopped.");
        }

        // Simulate asynchronous processing (e.g., data transformations)
        private Task ProcessSingleDataAsync(int data)
        {
            return Task.Run(() =>
            {
                // Simulate processing (e.g., apply filter, calculation, or transformation)
                Thread.Sleep(300); // Simulate some delay in processing
                Console.WriteLine($"Processed data: {data * 2}"); // Example processing
            });
        }

        // Stop the data collection and processing gracefully
        public void Stop()
        {
            cts.Cancel();  // Cancel the tasks
        }
    }

    class MultithreadApplication
    {
        public void Run()
        {
            var adcSimulator = new ADCDataSimulator();
            adcSimulator.Start();  // Start the data collection and processing

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();  // Wait for user input to stop the simulation

            adcSimulator.Stop();  // Stop the simulation
            Console.WriteLine("Simulation stopped.");
        }
    }
}
    