﻿using System.ComponentModel.DataAnnotations.Schema;
namespace MiniInstagram.Domain;

public class BaseModel<T>
{
    [Column("id")]
    public T Id { get; set; }
}