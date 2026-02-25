using Exp2;

class MainClass
{
    static void Main(String[] args)
    {
        //1.creating object
        Car.createObj();
        Console.WriteLine();

        //2.creating multiple object
        MultipleObj.multipleObj();
        Console.WriteLine();

        //3.class members
        ClassMember.classMember();
        Console.WriteLine();

        //4.class functions
        ClassFunctions.classFunctions();
        Console.WriteLine();

        //5.constructors
        Constructors.constructors();
        Console.WriteLine();

        //6.access modifiers
        AccessModifiers.accessModifiers();
        AccessModifiers.getModel();
        Console.WriteLine();

        //7.properties
        Program.propertiesCode();
        Console.WriteLine();

        //8.inheritance
        Inheritance.inheritanceCode();
        Console.WriteLine();

        //9.polymorphism
        Polymorphism.polymorphismCode();
        Console.WriteLine();

        //10.abstract class
        AbstractClass.abstratClass();
        Console.WriteLine();

        //11.interface
        InterfaceOOP.interfaceOOP();
        Console.WriteLine();

        //12.multiple interface
        MultipleInterface.multipleInterface();
        Console.WriteLine();

        //13.enum code
        EnumCode.enumCode();
        Console.WriteLine();

    }
}