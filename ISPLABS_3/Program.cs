using System;
class human
{

    public string fio;
    public int year;
}

class student
{

    public int curse;
    public string tipe_educ;
    public human ff=new human();

}


class stud_spesiation
{

    public string spec;
    public student st= new student();
}


namespace ISPLAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ISP_LAB");
            stud_spesiation std = new stud_spesiation();

            std.spec = "KSIS";

            std.st.tipe_educ = "free";
            std.st.ff.fio = "Andrey Viktor Agibailov";
            std.st.ff.year = 1975;
            std.st.curse = 4;
            Console.WriteLine(std.spec);
            Console.WriteLine(std.st.curse);
            Console.WriteLine(std.st.tipe_educ);
            Console.WriteLine(std.st.ff.fio);
            Console.WriteLine(std.st.ff.year);

        }
    }
}
