using System;
using System.Collections.Generic;
using System.IO;

public class Comment
{
    private string _namePerson;
    private string _commentText;

    public Comment(string namePerson, string commentText)
    {
        _namePerson = namePerson;
        _commentText = commentText;
    }

    public string GetCommentDisplay()
    {
        return $"Name: {_namePerson} - Comment: \"{_commentText}\"";
    }
}