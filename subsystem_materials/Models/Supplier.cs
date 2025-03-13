using System;
using System.Collections.Generic;

namespace subsystem_materials.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public short IdSupplierType { get; set; }

    public string NameSupplier { get; set; } = null!;

    public string Inn { get; set; } = null!;

    public bool IsActive { get; set; }


    //навигационные свойства
    public virtual SupplierType SupplierType { get; set; } = null!;

    public virtual ICollection<SuppliersMaterial> SuppliersMaterials { get; set; } = new List<SuppliersMaterial>();
}
