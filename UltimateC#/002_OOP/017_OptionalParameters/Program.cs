


// daysFromNow = 14 is used.
var appointmentTwoWeeksFromNow = new MedicalAppointment("Bob Smith", 14);


/* Optional Parameter:
 * The default value must be compile-time constant.
 * The optional parameters must appear after all required parameters.
 */

// daysFromNow is optional parameter, if its not assigned then default value of 7 is used (from its definition)
var appointmentOneWeeksFromNow = new MedicalAppointment("Marget Smith");

// In case of ambiguity between two same methods,
// The method with no optional parameters will always have precedence before the methods
// that do have some optional parameters.





class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    // "daysFromNow = 7" is an optional parameter,
    // if daysFromNow is not used then 
    public MedicalAppointment(string patientName, int daysFromNow = 7)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    //using public GetDate() to get the private _date value
    public DateTime GetDate() => _date;
}