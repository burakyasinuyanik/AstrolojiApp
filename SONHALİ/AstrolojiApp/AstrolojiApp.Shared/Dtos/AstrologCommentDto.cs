using System;
using System.ComponentModel.DataAnnotations;

namespace AstrolojiApp.Shared.Dtos;

public class AstrologCommentDto
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }

    [Required(ErrorMessage = "Lütfen bir resim yükleyin.")]
    public string? Image { get; set; }
}
