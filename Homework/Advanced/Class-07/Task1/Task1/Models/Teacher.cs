using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Teacher
    {
        // Public properties to store teacher information, using auto-implemented properties
        public string Name { get; set; }      // Stores the teacher's name
        public int Age { get; set; }          // Stores the teacher's age
        public string Email { get; set; }     // Stores the teacher's email
        public string Subject { get; set; }   // Stores the subject the teacher teaches

        // Constructor to initialize a new Teacher object with basic information
        public Teacher(string name, int age, string email, string subject)
        {
            Name = name;      // Assigns the passed name to the Name property
            Age = age;        // Assigns the passed age to the Age property
            Email = email;    // Assigns the passed email to the Email property
            Subject = subject;// Assigns the passed subject to the Subject property
        }

        // Event declaration that will be used to notify students
        // Action<string, string> is a delegate that takes two string parameters (teacherName and message)
        public event Action<string, string>? NotificationEvent;

        // Private dictionary to keep track of which student is subscribed to which notification handler
        // Key: Student object, Value: The specific notification handler for that student
        private Dictionary<Students, Action<string, string>> _subscriptions = new();

        // Method to subscribe a student to teacher's notifications
        public void Subscribe(Students student)
        {
            // Define a local function that handles the notification for this specific student
            // This ensures each student gets their own personalized message handling
            void Handler(string teacherName, string message)
            {
                Console.WriteLine($"[{student.Name}] Notification from {teacherName}: {message}");
            }

            // Store the handler in the dictionary with the student as the key
            _subscriptions[student] = Handler;

            // Add the handler to the event
            NotificationEvent += Handler;

            // Print confirmation of subscription
            Console.WriteLine($"{student.Name} subscribed to {Name}'s notifications.");
        }

        // Method to unsubscribe a student from teacher's notifications
        public void Unsubscribe(Students student)
        {
            // Try to get the student's specific handler from the dictionary
            if (_subscriptions.TryGetValue(student, out var handler))
            {
                // Remove the handler from the event
                NotificationEvent -= handler;
                // Remove the student-handler pair from the dictionary
                _subscriptions.Remove(student);
                // Print confirmation of unsubscription
                Console.WriteLine($"{student.Name} unsubscribed from {Name}'s notifications.");
            }
        }

        // Method to send a notification to all subscribed students
        public void SendNotification(string message)
        {
            // Print that the teacher is sending notifications
            Console.WriteLine($"\n{Name} sending notifications...");
            // Invoke the event with teacher's name and message (if there are any subscribers)
            NotificationEvent?.Invoke(Name, message);
        }
    }
}
