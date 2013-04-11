namespace My.Sale {
    
    
    [Composite.Data.AutoUpdatebleAttribute()]
    [Composite.Data.DataScopeAttribute("public")]
    [Composite.Data.RelevantToUserTypeAttribute("Developer")]
    [Composite.Data.CodeGeneratedAttribute()]
    [Composite.Data.Hierarchy.DataAncestorProviderAttribute(typeof(Composite.Data.Hierarchy.DataAncestorProviders.NoAncestorDataAncestorProvider))]
    [Composite.Data.ImmutableTypeIdAttribute("bffd2719-f738-4399-af09-ec7f0292e7e8")]
    [Composite.Core.WebClient.Renderings.Data.KeyTemplatedXhtmlRendererAttribute(Composite.Core.WebClient.Renderings.Data.XhtmlRenderingType.Embedable, "<span>{label}</span>")]
    [Composite.Data.KeyPropertyNameAttribute("Id")]
    [Composite.Data.TitleAttribute("Products")]
    [Composite.Data.LabelPropertyNameAttribute("Name")]
    public interface Product : Composite.Data.IData, Composite.Data.ProcessControlled.IProcessControlled, Composite.Data.ProcessControlled.ILocalizedControlled {
        
        [Composite.Data.ImmutableFieldIdAttribute("b0af1a2c-f93b-4b59-9883-87143b56733b")]
        [Composite.Data.FunctionBasedNewInstanceDefaultFieldValueAttribute("<f:function name=\"Composite.Utils.Guid.NewGuid\" xmlns:f=\"http://www.composite.net" +
            "/ns/function/1.0\" />")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(-1)]
        System.Guid Id {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("16b979a0-84f4-43f2-909e-bc0b38529d06")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 256)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.FieldPositionAttribute(0)]
        [Composite.Data.Validation.Validators.StringSizeValidatorAttribute(0, 256)]
        [Composite.Data.DefaultFieldStringValueAttribute("")]
        string Name {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("9a742dd1-42b8-4715-bd14-4cf47829dfb5")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 1024, IsNullable=true)]
        [Composite.Data.FieldPositionAttribute(1)]
        [Composite.Data.Validation.Validators.NullStringLengthValidatorAttribute(0, 1024)]
        string Summary {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("ba09cf37-eb6e-41d5-a46a-474ded31d4ec")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.LargeString, IsNullable=true)]
        [Composite.Data.FieldPositionAttribute(2)]
        string Description {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("a0c56a6c-e5be-41be-8ad6-dde4131e0b27")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Decimal, 10, 2, IsNullable=true)]
        [Composite.Data.FieldPositionAttribute(3)]
        [Composite.Data.Validation.Validators.DecimalPrecisionValidatorAttribute(2)]
        System.Nullable<decimal> Price {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("503a7c74-3fc6-40ad-aaf2-7dbd68ee443b")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.String, 2048, IsNullable=true)]
        [Composite.Data.FieldPositionAttribute(4)]
        [Composite.Data.Validation.Validators.NullStringLengthValidatorAttribute(0, 2048)]
        [Composite.Data.ForeignKeyAttribute("Composite.Data.Types.IImageFile,Composite", AllowCascadeDeletes=true, NullableString=true)]
        string Image {
            get;
            set;
        }
        
        [Composite.Data.ImmutableFieldIdAttribute("87277d00-18b0-48e5-8ae5-c6ca42a679eb")]
        [Composite.Data.StoreFieldTypeAttribute(Composite.Data.PhysicalStoreFieldType.Guid)]
        [Microsoft.Practices.EnterpriseLibrary.Validation.Validators.NotNullValidatorAttribute()]
        [Composite.Data.Validation.Validators.GuidNotEmptyAttribute()]
        [Composite.Data.FieldPositionAttribute(5)]
        [Composite.Data.DefaultFieldGuidValueAttribute("00000000-0000-0000-0000-000000000000")]
        [Composite.Data.ForeignKeyAttribute("My.Sale.Category", AllowCascadeDeletes=true, NullReferenceValue="{00000000-0000-0000-0000-000000000000}")]
        System.Guid Category {
            get;
            set;
        }
    }
}
