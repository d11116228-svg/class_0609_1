using System;

public class Student
{
    public int Mid;
    public int Final;

    public Student(int m, int f)
    {
        Mid = m;
        Final = f;
    }

    public int Plus(int a, int b)
    {
        int temp;
        temp = (Mid + Final) / 2;
        return temp;
    }

    public static Student operator +(Student a, Student b)
    {
        Student temp = new Student(0, 0);
        temp.Mid = (a.Mid + b.Mid) / 2;
        temp.Final = (a.Final + b.Final) / 2;
        return temp;
    }
}