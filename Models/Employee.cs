using System;
using System.Collections.Generic;

namespace EFDemo2.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }
}


class demo
{
    void method()
    {
        Employee e1;   //variable of a class
        
       e1 = new Employee(); //instance of a class

        Employee e2;
        e2 = e1;   //Reference of a class 


        e1 = null;   //defeferencing of instance
    }
}