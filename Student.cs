using System;
using System.Collections.Generic;

public class Student
{
    // Private fields 
    // TODO: add private fields for firstName (string), lastName (string), email (string)

 
    // TODO: add a private List<Appointment> to hold appointments


    // Constructors 
    // TODO: Parameterized constructor - accept firstName, lastName, email
    public Student(string firstName, string lastName, string email)
    {
        // TIP: call Update methods for validation instead of assigning directly

    }

    // "Getter" methods 
    // string GetFirstName()
    public string GetFirstName()
    {

    }
    // TODO: string GetLastName()
    public string GetLastName()
    {

    }
    // TODO: string GetEmail()
    public string GetEmail()
    {

    }
    // TODO: string GetFullName()
    public string GetFullName()
    {

    }

    // "Setter" methods with validation 
    public bool UpdateFirstName(string firstName)
    {
        if (string.IsNullOrWhiteSpace(firstName))
        {
            return false;
        }
        _firstName = firstName.Trim();
        return true;
    }

    // TODO: bool UpdateLastName(string lastName)    // non-empty
    public bool UpdateLastName(string lastName)
    {

    }

    // TODO: bool UpdateEmail(string email)          // contains "@" minimally
    public bool UpdateEmail(string email)
    {

    }

    // TODO: void AddAppointment(Appointment appt)
    public void AddAppointment(Appointment appt)
    {

    }

    // TODO: string GetScheduleSummary()  // 1-per-line human-readable
    public string GetScheduleSummary()
    {
        if (_appointments.Count == 0) return "No appointments scheduled.";

        // TODO: Complete this method to return a string of appointments
    }
}
