#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace Assignment_First_Connection.Models;
public class Mascota
{
    [Key]
    public int MascotaId {get;set;}
    public string Name {get;set;}
    public string Tipo_Mascota {get;set;}
    public int Edad {get;set;}
    public bool Calvo_NoCalvo {get;set;}
    public DateTime CreatedAt {get;set;} = DateTime.Now;
    public DateTime UpdatedAt {get;set;} = DateTime.Now;    
}