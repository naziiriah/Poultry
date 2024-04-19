using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Poultry.Models.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Poultry.Models;

public class PoultryBase : IAuditable
{

    public PoultryBase() 
    {
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
    }
    [ValidateNever]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Key]
    public Guid Guid = new Guid();
    public DateTime Created { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime Modified { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public DateTime? Deleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Guid? CreatedByUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Guid? ModifiedByUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Guid? DeletedByUser { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
}
