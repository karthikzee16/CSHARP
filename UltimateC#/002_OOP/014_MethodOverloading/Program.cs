var medicalAppointment = new MedicalAppointment(
    "John Smith",new DateTime(2023,4,3));


// reschedule and print
medicalAppointment.Reschedule(new DateTime(2023, 4, 4));

Console.ReadKey();






class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    //Constructor Overloading
    public MedicalAppointment(string patientName) :
        this(patientName, 7)  // calls below constructor
    {
        // to remove code duplication, below code is removed

        /*_patientName = patientName;
        _date = DateTime.Now.AddDays(7); // appointment booked 7 days from now
        */

    }

    // Code repition.
    public MedicalAppointment(string patientName, int daysFromNow)
    {
        _patientName = patientName;
        _date = DateTime.Now.AddDays(daysFromNow);
    }

    //using public GetDate() to get the private _date value

    // expression bodied method (=> is lambda operator)
    public DateTime GetDate() => _date;
    public void Reschedule(DateTime date)
    {
        _date=date;
        var printer = new MedicalAppointmentPrinter();

        //"this" keyword to refer to the current instance of a class.
        printer.Print(this);
    }

    //Method Overloading: same method names with DIFFERENT signature(parameters & return types)

    public void Reschedule(int day,int month)
    {
        _date = new DateTime(_date.Year, month, day);

    }


    // method overloading with same method and SAME signature will not work.
    // better to chose differne method name in this case

    /* public void Reschedule(int monthsToAdd, int daysToAdd)
     {
         _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);

     }*/




}

class MedicalAppointmentPrinter
{
    public void Print(MedicalAppointment medicalAppointment)
    {
        Console.WriteLine("Appointment will take place on "+ medicalAppointment.GetDate());
    }
}