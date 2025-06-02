using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Models
{
    public class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }

        public Teacher(string name, int age, string email, string subject)
        {
            Name = name;
            Age = age;
            Email = email;
            Subject = subject;
        }
        // Other properties...

        // CHANGED: Now takes two strings (teacherName, message)
        public event Action<string, string>? NotificationEvent;

        // Dictionary to track subscriptions
        private Dictionary<Students, Action<string, string>> _subscriptions = new();

        public void Subscribe(Students student)  // Now accepts Students object
        {
            // Create handler specific to this student
            void Handler(string teacherName, string message)
            {
                Console.WriteLine($"[{student.Name}] Notification from {teacherName}: {message}");
            }

            // Store handler in dictionary
            _subscriptions[student] = Handler;

            // Subscribe to event
            NotificationEvent += Handler;
            Console.WriteLine($"{student.Name} subscribed to {Name}'s notifications.");
        }

        public void Unsubscribe(Students student)  // Now accepts Students object
        {
            if (_subscriptions.TryGetValue(student, out var handler))
            {
                NotificationEvent -= handler;
                _subscriptions.Remove(student);
                Console.WriteLine($"{student.Name} unsubscribed from {Name}'s notifications.");
            }
        }

        public void SendNotification(string message)
        {
            Console.WriteLine($"\n{Name} sending notifications...");
            NotificationEvent?.Invoke(Name, message);  // Pass teacher name + message
        }
    }
}
