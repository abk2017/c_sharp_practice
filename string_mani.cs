using System;

enum Department {CHEM,CIVE, ECE, MGMT, MME,SYDE};

class Student
{
    // Declare the five data fields here (name, id, grade1, grade2, grade3)
	string name;//**
	string id;
	double grade1;
	double grade2;
	double grade3;
	Department department;
	
	
	// Constructor takes arguments for each field
	// DONT FORGET VARIABLE TYPES (string,double etc)
	public Student (string name,string id,double grade1,double grade2,
		double grade3)//^these variables only exist in the following brackets
		
	{
		this.name = name; //this refers to //**
		this.id = id;
		this.grade1 = grade1;
		this.grade2 = grade2;
		this.grade3 = grade3;
	
	}


    // Ex4: Create a second constructor which takes an additional
    // argument for the student's department, and assigns the argument to the
    // field
	public Student(string name,string id,double grade1,double grade2,
		double grade3, Department department)
		{
		this.name = name;
		this.id = id;
		this.grade1 = grade1;
		this.grade2 = grade2;
		this.grade3 = grade3;
		this.department = department;
	
		}

    // method to calculate and return the overall average here
	// Do not need Parameters cause it already has  ACCESS
	public double Average()//result only exists in the following w.o the return statement
	{
		double result;
		result = (grade1+grade2+grade3)/3d;
		return result;
	}

    // ToString method here to return a string
	// {variable order, alignment , Decimal Place} 
	// - alignment for left aligned
	//TO GET MARK AVERAGE CALL IT , DO NOT WRITE RESULT
	public override string ToString()
	{
		return string.Format("{0,-12} {1,-9}"+ 
		"{7,-10}{2,-9:F1}{3,-9:F1}{4,-9:F1}{5,-9:F1}{6,-9}", name,id,grade1,grade2,grade3,Average(),Passed(),department);
	}


    // Ex3: Write a Property here which enables accessing and mutating grade1
	//Should have PUBLIC acces_modifier
	//BY CONVENTION NAME SHOULD BE SAME AS VARIABLE
	// VALUE TYPE MUST BE THE SAME AS VARIABLE
	//get{}//access data field
	//set{}//modify data field
	//value is a key word
	
	public double Grade1
	{
		get
		{
			return grade1;
		}
		set
		{	
			grade1 = value;
		}
	}
	
	//DO NOT NEED PARAMETERS BECAUSE IT HAS ACCESS
	// DO NOT NEED QUOTATIONS FOR false or true in bool
    public bool Passed()
	{
		bool pass;

		
		if(Average()>60d)
		{
			pass = true;
		}
		else
		{
			pass = false;
		}
	
		return pass;
	}
}

class TestStudent
{
    static void Main()
    {
		//PUT QUOTATIONS IN BETWEEN STRINGS and d beside the numbers
        Student s1 = new Student("John Smith","jsmith",50d,65d,42d);
		Student s2 = new Student("Jane Doe","jdoe",78d,81d,86d);
		Student s3 = new Student("Max Power", "mpower",100d,100d,99d,Department.ECE);

        // Ex4: Instantiate a new student object using the new constructor

        Console.WriteLine("\n\t\t     UNIVERSITY OF WATERLOO STUDENTS");
        Console.WriteLine("\t\t==========================================\n");
        Console.WriteLine("Name        ID       Program   Grade 1  " +
            "Grade 2  Grade 3  Average  Pass?");
        Console.WriteLine("----------------------------------------" +
            "--------------------------------");
			

        Console.WriteLine(s1);
        Console.WriteLine(s2);
		Console.WriteLine(s3);
        // Ex3: Use the property of the class to raise grade 1 of the failing
        // student object and output the student's information again
		//Joe change grade1 to 100
		//DO NOT USE BRACKETS THIS CALLS THE SET
		s1.Grade1 = 100d;
		
		Console.WriteLine(s1);

        // Ex4: Output student data with the new department field
    }
}
