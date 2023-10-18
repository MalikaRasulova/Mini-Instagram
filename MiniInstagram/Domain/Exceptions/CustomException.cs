﻿
namespace MiniInstagram.Domain.Exceptions;
public class CustomException : Exception
{
    public int StatusCode { get; set; }

    public CustomException(int statusCode,string message) : base(message)
    {
        StatusCode = StatusCode;
    }
}