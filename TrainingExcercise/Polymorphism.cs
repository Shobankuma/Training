using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    class Smartphone
    {
        // Virtual method that can be overridden by derived classes
        public virtual void Ring()
        {
            Console.WriteLine("The smartphone is ringing with a default ringtone.");
        }
    }

    // Derived class: iPhone
    class iPhone : Smartphone
    {
        // Override the Ring method for iPhone
        public override void Ring()
        {
            Console.WriteLine("The iPhone is ringing with an iPhone ringtone.");
        }
    }

    // Derived class: Android
    class Android : Smartphone
    {
        // Override the Ring method for Android
        public override void Ring()
        {
            Console.WriteLine("The Android phone is ringing with an Android ringtone.");
        }
    }

    // Main program
    class Polymorphism
    {
       public void Run()
        {
            // Create objects of different types
            Smartphone myPhone1 = new iPhone();  // Base class reference, but iPhone object
            Smartphone myPhone2 = new Android(); // Base class reference, but Android object

            // Call the Ring method on both objects
            myPhone1.Ring();  // Calls the Ring method of iPhone
            myPhone2.Ring();  // Calls the Ring method of Android
        }
    }

}

