using System;

internal class DoctorService
{
    private Doctor[] _doctors;
    public DoctorService(Doctor[] doctors)
    {
        _doctors = doctors;
    }
//GetAll
    public void GetAll()
    {
        foreach (Doctor doctor in _doctors)
        {
            doctor.GetInfo();
        }
    }

//SearchByFullName
    public void SearchByFullName(string fullName)
    {
        foreach (Doctor doctor in _doctors)
        {
            if (doctor.FullName.ToLower().Contains(fullName.ToLower()))
            {
                doctor.GetInfo();
            }
        }
    }

//SortByAge
    public void SortByAge()
    {
        for (int i = 0; i < _doctors.Length - 1; i++)
        {
            for (int j = i + 1; j < _doctors.Length; j++)
            {
                if (_doctors[i].Age > _doctors[j].Age)
                {
                    Doctor temp = _doctors[i];
                    _doctors[i] = _doctors[j];
                    _doctors[j] = temp;
                }
            }
        }
    }

//GetAverageByAge
    public double GetAverageByAge()
    {
        int sum = 0;

        foreach (Doctor doctor in _doctors)
        {
            sum += doctor.Age;
        }

        return (double)sum / _doctors.Length;
    }
}