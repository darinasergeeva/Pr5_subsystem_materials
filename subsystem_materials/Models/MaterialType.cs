using subsystem_materials.Models;
using System;
using System.Collections.Generic;

namespace subsystem_materials;

public partial class MaterialType
{
    public short Id { get; set; }

    public string TypeMaterial { get; set; } = null!;


    //навигационные свойства
    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
