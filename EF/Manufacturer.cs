
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace EquipmentRent3ISP9_7.EF
{

using System;
    using System.Collections.Generic;
    
public partial class Manufacturer
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Manufacturer()
    {

        this.ManufacturerProduct = new HashSet<ManufacturerProduct>();

        this.Product = new HashSet<Product>();

    }


    public int IdManufacturer { get; set; }

    public string ManufacturerName { get; set; }

    public string ManufacturerAdress { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ManufacturerProduct> ManufacturerProduct { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Product> Product { get; set; }

}

}
