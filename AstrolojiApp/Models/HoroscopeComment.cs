using System;

namespace AstrolojiApp.Models;

public class HoroscopeComment
{
public int Id { get; set; }
public int HoroscopeId { get; set; }
public string Daily { get; set; }   
public string Monthly { get; set; } 
public string Annual { get; set; }

}