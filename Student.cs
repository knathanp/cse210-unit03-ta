using System;
using System.Collections.Generic;

public class Student
{
    // Private fields 
    // TODO: add private fields for firstName (string), lastName (string), email (string)
    private string _firstName = "";
    private string _lastName = "";
    private string _email = "";

    // TODO: add a private List<Appointment> to hold appointments
    private List<Appointment> _appointments;

    // Constructors 
    // TODO: Parameterized constructor - accept firstName, lastName, email
    public Student(string firstName, string lastName, string email)
    {
        // TIP: call Update methods for validation instead of assigning directly
        UpdateFirstName(firstName);
        UpdateLastName(lastName);
        UpdateEmail(email);
        _appointments = new List<Appointment>();
    }

    // "Getter" methods 
    // TODO: string GetFirstName()
    public string GetFirstName()
    {
        return _firstName;
    }
    // TODO: string GetLastName()
    public string GetLastName()
    {
        return _lastName;
    }
    // TODO: string GetEmail()
    public string GetEmail()
    {
        return _email;
    }
    // TODO: string GetFullName()
    public string GetFullName()
    {
        return $"{_firstName} {_lastName}";
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
        if (string.IsNullOrWhiteSpace(lastName))
        {
            return false;
        }
        _lastName = lastName.Trim();
        return true;
    }

    // TODO: bool UpdateEmail(string email)          // contains "@" minimally
    public bool UpdateEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            return false;
        }
        else if (!email.Contains('@'))
        {
            return false;
        }
        _email = email.Trim();
        return true;
    }

    // Appointment management (encapsulation over the list) 
    // TODO: void AddAppointment(Appointment appt)
    public void AddAppointment(Appointment appt)
    {
        _appointments.Add(appt);
    }

    // TODO: string GetScheduleSummary()  // 1-per-line human-readable
    public string GetScheduleSummary()
    {
        if (_appointments.Count == 0) return "No appointments scheduled.";
        string result = "";
        foreach (Appointment appt in _appointments)
        {
            result += $"{appt.GetDetails()}\n";
        }
        return result;
    }
}
