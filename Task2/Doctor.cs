using System;
//Doctor clasiniz olacaq : (FullName, Age, Email, Address)
internal class Doctor
{
    public string FullName {get; set;}
    public int Age {get; set;}
    public string Email {get; set;}
    public string Address {get; set;}
    public Doctor(string fullname,int age, string email, string address)
    {
        FullName= fullname;
        Age = age;
        Email = email;
        Address = address;
    }
}