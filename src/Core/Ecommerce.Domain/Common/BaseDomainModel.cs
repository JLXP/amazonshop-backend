//Todas las clases padres menos las de seguridad
namespace Ecommerce.Domain.Common;

//Al hace clase padre tiene que se abstracta
public abstract class BaseDomainModel
{
    //Todas las clases de Negocio y todas empiezan con un id
    public int Id { get; set; }
    public DateTime? CreatedDate { get; set; }
    //Quien es el usuario
    public string? CreatedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }
    public DateTime? LastModifiedBy { get; set; }
}