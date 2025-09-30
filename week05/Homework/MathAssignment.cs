using System;
using System.Collections.Generic;
using System.IO;

public class MathAssignment :Assigment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textBookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
    
}