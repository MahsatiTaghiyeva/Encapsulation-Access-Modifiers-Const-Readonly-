Doctor doctor1 = new Doctor(
    "Ali Veliyev",
    34,
    "ali@gmail.com",
    "Baku"
);

Doctor doctor2 = new Doctor(
    "Leyla Hasanli",
    28,
    "leyla@gmail.com",
    "Ganja"
);

Doctor doctor3 = new Doctor(
    "Murad Aliyev",
    45,
    "murad@gmail.com",
    "Baku"
);

Doctor[] doctors = { doctor1, doctor2, doctor3 };

DoctorService service = new DoctorService(doctors);
service.GetAll();
Console.WriteLine("Average age: " + service.GetAverageByAge());
service.SearchByFullName("Ali");
service.SortByAge();
Console.WriteLine("After sorting:");
service.GetAll();