
/*Homework 8: Hospital System
● Implement the following system for a hospital
● There are 20 different specialization (e.g. Children, Surgery, etc)
● For each specialization, there are only 5 available spots [queue]
● Adding a patient
○ Read the requested specialization [1-20].
○ Read his name and status (0 = regular, 1 urgent)
○ If 5 patients exist, apologize and don’t accept.
○ If the user is regular, add in end of queue. Otherwise, add in Begin
● Print patients, for the specializations that have waiting patients
● Dr pickup a patient
○ Read the requested specialization. If no patients, inform the doctor
○ Otherwise, ask the patient to go with the Dr. Remove from the queue*/
/*Homework 8: Hospital System
● Implement the following system for a hospital
● There are 20 different specialization (e.g. Children, Surgery, etc)
● For each specialization, there are only 5 available spots [queue]
● Adding a patient
○ Read the requested specialization [1-20].
○ Read his name and status (0 = regular, 1 urgent)
○ If 5 patients exist, apologize and don’t accept.
○ If the user is regular, add in end of queue. Otherwise, add in Begin
● Print patients, for the specializations that have waiting patients
● Dr pickup a patient
○ Read the requested specialization. If no patients, inform the doctor
○ Otherwise, ask the patient to go with the Dr. Remove from the queue*/

Queue<string>[] patients = new Queue<string>[20];
for (int i = 0; i < patients.Length; i++)
{
    patients[i] = new Queue<string>();
}

void AddPatient()
{
    Console.WriteLine("Enter specialization (1-20): ");
    int specialization = int.Parse(Console.ReadLine());
    if (specialization < 1 || specialization > 20)
    {
        Console.WriteLine("Invalid specialization");
        return;
    }

    if (patients[specialization - 1].Count >= 5)
    {
        Console.WriteLine("Sorry, no more spots available for this specialization");
        return;
    }

    Console.WriteLine("Enter patient name: ");
    string name = Console.ReadLine();

    Console.WriteLine("Enter patient status (0 = regular, 1 = urgent): ");
    int status = int.Parse(Console.ReadLine());

    if (status != 0 && status != 1)
    {
        Console.WriteLine("Invalid status");
        return;
    }

    if (status == 0)
    {
        patients[specialization - 1].Enqueue(name);
    }
    else
    {
        patients[specialization - 1].Enqueue(name);
        // Move the patient to the front of the queue
        string urgentPatient = patients[specialization - 1].Dequeue();
        patients[specialization - 1].Enqueue(urgentPatient);
    }
}

void PrintPatients()
{
    for (int i = 0; i < patients.Length; i++)
    {
        if (patients[i].Count > 0)
        {
            Console.WriteLine($"Specialization {i + 1}:");
            foreach (string patient in patients[i])
            {
                Console.WriteLine($"- {patient}");
            }
        }
    }
}

void GetNextPatient()
{
    Console.WriteLine("Enter specialization (1-20): ");
    int specialization = int.Parse(Console.ReadLine());
    if (specialization < 1 || specialization > 20)
    {
        Console.WriteLine("Invalid specialization");
        return;
    }

    if (patients[specialization - 1].Count == 0)
    {
        Console.WriteLine("No patients waiting for this specialization");
        return;
    }

    string nextPatient = patients[specialization - 1].Dequeue();
    Console.WriteLine($"Patient {nextPatient} is being seen by the doctor");
}

while (true)
{
    Console.WriteLine("Enter your Choice: ");
    Console.WriteLine("1. Add Patient");
    Console.WriteLine("2. Print Patients");
    Console.WriteLine("3. Get next patient");
    Console.WriteLine("4. Exit");
    int choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            AddPatient();
            break;
        case 2:
            PrintPatients();
            break;
        case 3:
            GetNextPatient();
            break;
        case 4:
            Environment.Exit(0);
            break;
    }
}
Console.WriteLine("Thank you for using the hospital system");
Console.ReadLine();
